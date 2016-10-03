using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Dodawanie
    {
        //ID1293
        public void dodawanie()
        {
            List<string> dodawanie = new List<string>();
            var liczbaPowtorzen = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < liczbaPowtorzen; i++)
            {
                var number = Console.ReadLine();
                dodawanie.Add(number);
            }
            foreach (var model in dodawanie)
            {
                var wynik = model.Split(' ').Select(x => Decimal.Parse(x)).Aggregate((x, y) => x + y);
                Console.WriteLine(wynik);
            }
            Console.ReadKey();
        }

    }
}
