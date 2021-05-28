using JsonExample.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // NUGET > Newtonsoft > to use the json options

            /*
                {
                "Processor": "1 GB",
                "RAM": "16 GB",
                "Hard Drive": "1 TB",
                "Display": "1280 x 1012"
                }
            */

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"D:\taux\GenericFIleData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                RequirementSystem obj = (RequirementSystem)serializer.Deserialize(file, typeof(RequirementSystem));
                Console.WriteLine(obj.RAM);
            }
        }
    }
}
