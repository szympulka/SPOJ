using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class CzyUmieszPotegowac
    {
        // ID499
        //R = reszta z dzielenia przez 4
        //Gdy R =   _:| 1 | 2 | 3 | 0 |
        //           =================
        //Dla C = 2_:| 2 | 4 | 8 | 6 |
        //Dla C = 3_:| 3 | 9 | 7 | 1 |
        //Dla C = 7_:| 7 | 9 | 3 | 1 |
        //Dla C = 8_:| 8 | 4 | 2 | 6 |
        public void czyUmieszPotegowac()
        {
            List<string> war = new List<string>();
            var liczbaPowtorzen = Int64.Parse(Console.ReadLine());
            for (int i = 0; i < liczbaPowtorzen; i++)
            {
                var number = Console.ReadLine();
                war.Add(number);
            }
            foreach (var item in war)
            {
                var ints = item.Split(' ').Select(x => Int64.Parse(x)).ToArray();
                var ostatniaCyfraWykladnika = ints[0].ToString().Last() - '0';
                var potega = ints[1] - '0';
                if (ostatniaCyfraWykladnika == 1 || ostatniaCyfraWykladnika == 6 || ostatniaCyfraWykladnika == 5 || ostatniaCyfraWykladnika == 0)
                {
                    Console.WriteLine(ostatniaCyfraWykladnika);
                    continue;
                }
                if (ostatniaCyfraWykladnika == 7 || ostatniaCyfraWykladnika ==3)
                {
                    if ((potega % 4 == 1 && ostatniaCyfraWykladnika == 7) || (potega %4 == 3 && ostatniaCyfraWykladnika == 3)) { Console.WriteLine("7");continue;}
                    if (potega%4 == 2) { Console.WriteLine("9");continue;}
                    if ((potega%4 == 3 && ostatniaCyfraWykladnika ==7) || (potega%4 ==1 && ostatniaCyfraWykladnika==3)) { Console.WriteLine("3");continue;}              
                }
                if (ostatniaCyfraWykladnika == 8 || ostatniaCyfraWykladnika == 2)
                {
                    if ((potega % 4 == 1 && ostatniaCyfraWykladnika == 8) || (potega % 4 == 3 && ostatniaCyfraWykladnika == 2)) { Console.WriteLine("8"); continue; }
                    if (potega % 4 == 2) { Console.WriteLine("4"); continue; }
                    if ((potega % 4 == 3 && ostatniaCyfraWykladnika == 8) || (potega % 4 == 1 && ostatniaCyfraWykladnika == 2)) { Console.WriteLine("2"); continue; }
                }
                if (ints[1] % 2 == 0)
                {
                    if (ostatniaCyfraWykladnika == 4 || ostatniaCyfraWykladnika ==2|| ostatniaCyfraWykladnika == 8) Console.WriteLine("6");
                    if (ostatniaCyfraWykladnika == 9 || ostatniaCyfraWykladnika == 3 || ostatniaCyfraWykladnika == 7) Console.WriteLine("1"); 
                }
                else
                {
                    if (ostatniaCyfraWykladnika == 4) Console.WriteLine("4");
                    if (ostatniaCyfraWykladnika == 9)Console.WriteLine("9");                 
                }
            }
        }
    }
}
