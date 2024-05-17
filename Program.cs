using System.Text.Json;
using System.Xml.Serialization;
using static Serialization.JsonSerial;

namespace Serialization
{
    [XmlRoot("Data.Root")]
    public class Data
    {
        [XmlArray("Data.Root.Names")]
        [XmlArrayItem("Name")]
        public string[]? Names;
        [XmlElement(typeof(Entry))]
        [XmlElement(typeof(DataX))]
        public Entry[]? Entry;
        
    }
    [XmlType("Data.Entry")]
    public class Entry
    {
        [XmlAttribute]
        public string? LinkedEntry;
        [XmlElement("Data.Name")]
        public string? Name;
    }
    [XmlType("Data#ExtendedEntry")]
    public class DataX : Entry
    {
        [XmlElement("Data#Extended")]
        public string? Extended;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var xml = """
            //    <?xml version="1.0" encoding="utf-8"?>
            //    <Data.Root xmlns:xsi="https://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="https://www.w3.org/2001/XMLSchema">
            //        <Data.Root.Names>
            //            <Name>Name1</Name>
            //            <Name>Name2</Name>
            //            <Name>Name3</Name>
            //        </Data.Root.Names>
            //        <Data.Entry LinkedEntry="Name1">
            //            <Data.Name>Name2</Data.Name>
            //        </Data.Entry>
            //        <Data_x0023_ExtendedEntry LinkedEntry="Name2">
            //            <Data.Name>Name1</Data.Name>
            //            <Data_x0023_Extended>NameOne</Data_x00230Extended>
            //        </Data_x0023_ExtendedEntry>
            //    </Data.Root>
            //    """;
            //Data data = new Data();
            //data.Names = new string[] { "Name1", "Name2", "Name3" };
            //data.Entry = new Entry[2];
            //data.Entry[0] = new Entry();
            //data.Entry[0].LinkedEntry = "Name1";
            //data.Entry[0].Name = "Name2";
            //data.Entry[1] = new DataX { LinkedEntry = "Name2", Name="Name1",
            //    Extended = "NameOne"};

            //var serializer = new XmlSerializer(typeof(Data));
            //serializer.Serialize(Console.Out, data);
            var json = new StreamReader("E:\\Projects\\DotNet\\Serialization\\Json.txt").ReadToEnd();
            Weather weatherInfo = JsonSerializer.Deserialize<Weather>(json);
            var serializer = new XmlSerializer(typeof(Weather));
            serializer.Serialize(Console.Out,weatherInfo);
        }
    }
}
