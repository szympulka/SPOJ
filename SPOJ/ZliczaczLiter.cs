using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class ZliczaczLiter
    {
        //ID 1242
        public void zliczaczLiter()
        {
            List<string> tekst = new List<string>();
            Dictionary<string,int> alfabet = new Dictionary<string, int>();
            var ileLinijek = int.Parse(Console.ReadLine());
            for (int i = 0; i < ileLinijek; i++)
            {
                var add = Console.ReadLine();
                    tekst.Add(add);
            }
            foreach (var model in tekst)
            {
                var litery = model.Split(' ').ToArray();
              
                foreach (var item in litery)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!alfabet.ContainsKey(Char.ToString(item[i])))
                        {
                            alfabet.Add(Char.ToString(item[i]), 1);
                        }
                        else
                        {
                            alfabet[Char.ToString(item[i])]++;
                        }
                    }           

                }
            }
            foreach (var model in alfabet)
            {
                Console.WriteLine("{0} {1}",model.Key , model.Value);
            }
            Console.ReadKey();
        }
    }
}
