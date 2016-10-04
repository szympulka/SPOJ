using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class PredkoscSrednia
    {
        //ID1016
        public void predkoscSrednia()
        {
            List<string> tekst = new List<string>();
            var ileLinijek = int.Parse(Console.ReadLine());
            for (int i = 0; i < ileLinijek; i++)
            {
                var add = Console.ReadLine();
                tekst.Add(add);
            }
            foreach (var liczby in tekst)
            {
                var model = liczby.Split(' ').Select(x => int.Parse(x)).Aggregate((x, y) => (2*x*y)/(x + y));
                Console.WriteLine(model);
            }
            Console.ReadKey();
        }
    }
}
