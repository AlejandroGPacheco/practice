using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Wrapper
    {
        [JsonProperty("JsonValues")]
        public Person Person { get; set; }
    }
    public class Person

    {
        [JsonProperty("people")]
        public Dictionary<string, PersonInfo> People { get; set; }

    }
    public class PersonInfo
    {
        [JsonProperty("Name")]
        public string name { get; set; }

        [JsonProperty("Age")]
        public int age { get; set; }
    }
}
