using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class WalidacjaAdresuE_Mail
    {
        //ID 21023
        public void walidacjaAdresuEmail()
        {
            List<string> mail = new List<string>();
            var iloscLiczb = int.Parse(Console.ReadLine());
            bool itsTrue = true;
            for (int i = 0; i < iloscLiczb; i++)
            {
                var adres = Console.ReadLine();
                mail.Add(adres);
            }

            foreach (var item in mail)
            {
                var result = item.Split('@').ToArray();
                if (result[0].Length != 2) { Console.WriteLine("NIE"); continue; }
                var Before = result[0].IndexOfAny(new char[] {' ',',','/','?',':',';','"'});
                var resultAfter = result[1].Split('.').ToArray();
                for (int i = 0; i < result.Length; i++)
                {
                    if (resultAfter[i].Length == 0) { Console.WriteLine("NIE"); itsTrue = false; break;}
                    if (resultAfter[i].IndexOfAny(new char[] {' ', ',', '/', '?', ':', ';', '"'}) != -1) { itsTrue = false; break;}
                    if (i== result.Length-1) { Console.WriteLine("TAK");itsTrue = false;}
                }
                if (Before== -1 && itsTrue)
                {
                    itsTrue = false;
                    Console.WriteLine("TAK");   
                }
                else if (Before > 0)
                {
                    Console.WriteLine("NIE");
                }
          
            }
        }
    }


}
