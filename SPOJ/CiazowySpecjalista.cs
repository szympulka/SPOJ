using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class CiazowySpecjalista
    {
        //ID 1142
        public void ciazowy()
        {
            List<string> tekst = new List<string>();
            var ileLinijek = int.Parse(Console.ReadLine());
            for (int i = 0; i < ileLinijek; i++)
            {
                var add = Console.ReadLine();
                tekst.Add(add);
            }

        }
    }
}
