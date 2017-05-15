using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace JSONnetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //deserilaize JSON from file
            String JSONstring = File.ReadAllText(".../" +
                ".../JSON.json");

            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);

            Person p2 = new Person() { name = "ben", age = 46};
            string outputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", outputJSON);

            Console.ReadKey();
        }
    }
}
