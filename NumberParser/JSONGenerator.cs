using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public class JSONGenerator : IFileGenerator
    {
        public JSONGenerator()
        {

        }
        public void generate(int[] input)
        {
            JArray array = new JArray();
            
            StreamWriter file = File.CreateText("JSONFile.json");
            foreach (int number in input)
            {
                JObject numbers = new JObject();
                numbers.Add(new JProperty("Number", number));
                array.Add(numbers);


            }

            // write JSON directly to a file
          //  File.WriteAllText("JSONFile.json", array.ToString());
            using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    array.WriteTo(writer);
                }
            }
        }
    }

