using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NumberParser
{
    public class XMLGenerator : IFileGenerator
    {
        public int[] integerArray;
        public XMLGenerator()
        {
           // integerArray = input;

        }
        public void generate(int[] input)
        {
            using (XmlWriter writer = XmlWriter.Create("FileXml.xml"))
            {
                writer.WriteStartDocument();
                
                writer.WriteStartElement("Numbers");
               foreach(int number in input)
                {
                    writer.WriteStartElement("Number");
                    writer.WriteString(number.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
