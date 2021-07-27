/*
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using YamlDotNet.RepresentationModel;
//using SharpYaml.Serialization;
using YamlDotNet.Serialization;

namespace practice
{
    class Program
    {

        static void Main(string[] args)
        {
            var reader = new StreamReader("C:\\Users\\178788\\Desktop\\practice\\practice\\appsettings.yml");
            var yaml = new YamlStream();
            yaml.Load(reader);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            string key = string.Empty;

            foreach (var entry in mapping.Children)
            {
                var myKey = ((YamlScalarNode)entry.Key).Value;

                Console.WriteLine("Key: {0} Value: {1}", myKey, entry.Value);
                if (myKey != "turtle-doves")
                {
                    continue;
                }
                /*
                YamlScalarNode myScalarNode = new YamlScalarNode(myKey);
                var tmpItem = mapping.Children[myScalarNode];

                var items = (YamlSequenceNode)tmpItem;
                foreach (YamlMappingNode mNode in items)
                {
                    Console.WriteLine("{0}", mNode.Children[new YamlScalarNode("whatever")]);
                }
                */
            //}


            /*
            
            yaml.Load(reader);
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize<Dictionary<int, Item>>(reader);

            var serializer = new SerializerBuilder()
                .JsonCompatible()
                .Build();
            var json = serializer.Serialize(yamlObject);
            Console.WriteLine(json);
            

            
            //var yaml = new SharpYaml.Model.YamlStream();
            //yaml.Load(reader);
            /*var yamlPath = "appsettings.yml";
            
            var input = new StreamReader(yamlPath);

            var deserializer = new Serializer();
            var config = (Config)deserializer.Deserialize(input, typeof(Config));
            

        }
    }

}

*/
            
