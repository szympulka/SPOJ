using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Flamaster
    {
        //ID 506
        public void flamaster()
        {
            List<string> word = new List<string>();
            var liczbaPowtorzen = Int64.Parse(Console.ReadLine());
            int iloscLiter = 1;
            for (int i = 0; i < liczbaPowtorzen; i++)
            {
                var number = Console.ReadLine();
                word.Add(number);
            }
            foreach (var item in word)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (i == item.Length - 1)
                    {
                        goto Last;
                    }
                    if (item[i] == item[i + 1])
                    {
                        iloscLiter++;
                        continue;
                    }
                    Last:
                    if (iloscLiter > 2)
                    {
                        Console.Write($"{item[i]}{iloscLiter}");
                        iloscLiter = 1;
                        continue;
                    }
                    if (iloscLiter == 2)
                    {
                        Console.Write(item[i]);
                        Console.Write(item[i]);
                        iloscLiter = 1;
                        continue;

                    }
                    Console.Write(item[i]);
                }
                Console.WriteLine();

            }
        }

    }
}