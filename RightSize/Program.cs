using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //use args to access
            foreach (string a in args)
            {   
                
                int a_len = a.Length;
                if (a_len > 3 && a_len < 6)
                {
                    Console.WriteLine(a);
                }                    
                else if (a_len > 6)
                {
                    return;
                }
                    


            }
        }

    }
}
