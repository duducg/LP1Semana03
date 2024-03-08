using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for a string input
            Console.Write("Please input a \"string\" value: ");
            string instring = Console.ReadLine();
            
            //prompt user for a char input
            Console.Write("Please input a \"char\" value: ");
            string inchar = Console.ReadLine();
            char parse_char = Char.Parse(inchar);


            //print initial string replacing the char with X
            string new_string = "";
            foreach (char c in instring)
            {
                if (c == parse_char)
                {
                    new_string += 'X';
                }
                else
                {
                    new_string += c;
                }
            }
            Console.WriteLine($"Your censored \"string\" is {new_string}");
            

        }
    }
}
