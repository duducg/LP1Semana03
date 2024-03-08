using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {

            //parse data:
            float[,] a = new float[2, 2]; //2x2 float array
            float[] b = new float[2]; //2x1 float array
            
            
            for (int j = 0; j < args.Length ;j++)
            {

                float curr_val = float.Parse(args[j]);
                switch (j)
                {
                    case 0:
                        a[0, 0] = curr_val;
                        break;
                    case 1:
                        a[0, 1] = curr_val;
                        break;
                    case 2:
                        a[1, 0] = curr_val;
                        break;
                    case 3:
                        a[1, 1] = curr_val;
                        break;
                    case 4:
                        b[0] = curr_val;
                        break;                    
                    case 5:
                        b[1] = curr_val;
                        break;                   
                
                    default:
                        break;
                }
            }

            // //print arrays
            // //To test if it works
            // //a
            // for (int i = 0; i < a.GetLength(0); i++)
            // {
            //     for (int j = 0; j <a.GetLength(1); j++)
            //     {
            //         Console.Write(a[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            // //b
            // for (int d = 0; d < b.Length; d++)
            // {
            //     Console.WriteLine(b[d] + " ");
            // }

            //final multiplied array:
            float[] c = new float[2];
            c[0] = (a[0, 0] * b[0]) + (a[0, 1] * b[1]);
            c[1] = (a[1, 0] * b[0]) + (a[1, 1] * b[1]);
            
            for (int d = 0; d < c.Length; d++)
            {
                Console.WriteLine(c[d] + " ");
            }
            
            
            

        }
    }
}
