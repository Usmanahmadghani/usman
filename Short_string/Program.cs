using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string output = string.Empty;
            string inputString = Console.ReadLine();
            string[] splitStrings = inputString.Split(' ');
            for (int i = splitStrings.Length - 1; i > -1; i--)
            {
                output = output + splitStrings[i] + " ";
            }

            Console.WriteLine(output);

            Console.ReadKey();
        }
        public string ReverseFullSentence(string inputString)
        {
            string output = string.Empty;
            string[] splitStrings = inputString.Split(' ');
            for (int i = splitStrings.Length - 1; i > -1; i--)
            {
                output = output + splitStrings[i] + " ";
            }
            return output;
        }
        
    }
    public class Employee : Main
    {
        public void Show12()
        {
            
        }
    }
    public interface Main
    {
        void Show12();

    }
}
