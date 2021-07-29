
using Newtonsoft.Json;

using System;

using System.IO;

using YamlDotNet.RepresentationModel;


namespace practice
{
    public class JsonYaml
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("C:\\Users\\178788\\Desktop\\practice\\practice\\json1.json");
            string jsonString = reader.ReadToEnd();
            
            var people = JsonConvert.DeserializeObject<Wrapper>(jsonString).Person;
            foreach (var person in people.People)
            {
                Console.WriteLine("Name: {0} Age: {1} ", person.Value.name, person.Value.age);
            }

            var reader2 = new StreamReader("C:\\Users\\178788\\Desktop\\practice\\practice\\YamlPractice.yml");
            var yaml = new YamlStream();
            yaml.Load(reader2);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            

            foreach (var entry in mapping.Children)
            {
                var myKey = ((YamlScalarNode)entry.Key).Value;

                Console.WriteLine("Key: {0} Value: {1}", myKey, entry.Value);
                if (myKey != "turtle-doves")
                {
                    continue;
                }


            }
        }
    }
}


