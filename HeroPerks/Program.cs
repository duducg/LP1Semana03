using System;
using System.Collections.Generic;
namespace HeroPerks
{
    class Program
    {
        //enumeration flag:
        [Flags]
            enum Perks 
            {
                WaterBreathing = 1 << 0,
                Stealth = 1 << 1,
                AutoHeal = 1 << 2,
                DoubleJump = 1 << 3

            }
        static void Main(string[] args)
        {
            Perks myPerks;

            int w, a, s, d;
            w = 0;
            a = 0;
            s = 0;
            d = 0;
            int perkcheck = 0;
           
            bool stealth_ = false;
            bool autoh_ = false;
            bool doublej_ = false;            

            bool unknown = false;
            foreach (char c in args[0])
            {
                //tally up all the keys
                switch(c)
                {
                    case 'w':
                        w += 1;
                    break;
                    case 'a':
                        a += 1;
                        break;
                    case 's':
                        s += 1;
                        break;
                    case 'd':
                        d += 1;
                        break;
                    default:
                        unknown = true;
                        break;
                    
                }

            }
            //easier to iterate:
            List<int> key_counts = new List<int>()
            {
                w,
                a,
                s,
                d
            };
            
            if(!unknown)
            {
                Console.WriteLine("Unknown perk!");
            }
            else
            {
                    for ( int j = 0; j < 4; j++)
                    {
                        int i = key_counts[j];
                        Perks p1 = (Perks)i;
                        if (i == 0 || i % 2 == 0)
                        {
                            //deactivate                    
                            myPerks &= ~(Perks)i;
                        }
                        //second rule:
                        else if (!(i % 2 == 0) && i != 0)
                        {      
                            //activate          
                            myPerks ^= (Perks)i;                            
                        }


                    }
                    //check if empty
                    if ((myPerks & Perks.WaterBreathing) == Perks.WaterBreathing)
                    {


                        perkcheck += 1;
                    }
                    if ((myPerks & Perks.Stealth) == Perks.Stealth)
                    {
                        stealth_ = true;
                        perkcheck += 1;
                    }

                    if ((myPerks & Perks.AutoHeal) == Perks.AutoHeal)
                    {
                        autoh_ = true;
                        perkcheck += 1;
                    }

                    if ((myPerks & Perks.DoubleJump) == Perks.DoubleJump)
                    {
                        doublej_ = true;
                        perkcheck += 1;
                    }

                    //check
                    if (perkcheck == 0)
                    {
                        Console.WriteLine("No perks at all!");
                    }
                    else if (doublej_ && stealth_)
                    {
                        Console.WriteLine("Silent jumper!");
                    }
                    if (!autoh_)
                    {
                        Console.WriteLine("Not gonna make it!");
                    }
                
            }
            
        
            
            Console.WriteLine(myPerks);       
            
            
            
            
        }
    }
}
