using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public class TxtGenerator : IFileGenerator
    {
        public int[] integerArray;
        public TxtGenerator()
        {

        }
        public void generate(int[] input)
        {
            string fileName = "FileTXT.txt";


            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }


            using (StreamWriter sw = File.CreateText(fileName))
            {
                foreach (int number in input)
                {
                    sw.WriteLine(number);

                }
            }
        }
    }
}
