using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;
using System.IO;

namespace MyFirstJsonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //deserilaize JSON from file
            String JSONstring = File.ReadAllText(".../" +
                ".../JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Persom p1 = ser.Deserialize<Persom>(JSONstring);
            Console.WriteLine(p1);

            Persom p2 = new Persom() { name = "mary", age = 72 };
            string outputJSON = ser.Serialize(p2);
            File.WriteAllText("Output.json", outputJSON);

            Console.ReadKey();
        }
    }
}
