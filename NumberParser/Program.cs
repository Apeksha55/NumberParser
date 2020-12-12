using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers;
            string extension;
            Console.Write("Enter Integers: ");
            numbers = Console.ReadLine();
            Console.Write("Enter Extension: ");
            extension = Console.ReadLine();
            try
            {
                int[] nums = Array.ConvertAll(numbers.Split(','), int.Parse);
                Array.Sort(nums);
                Array.Reverse(nums);
                IFileGenerator gen = Factory.GetFileInstance(extension);
                gen.generate(nums);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please provide input in below format: ");
                Console.WriteLine("Enter Integers:1,2,3");
                Console.WriteLine(" Extension:xml or json or txt");
                Console.ReadLine();
            }
          

            }
             
           
        }
        
    
}
