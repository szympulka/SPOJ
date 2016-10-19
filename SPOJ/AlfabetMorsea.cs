using System;
using System.Collections.Generic;
using System.Linq;

namespace SPOJ
{
    class AlfabetMorsea
    {
        // ID 22151	

        public void alfabetMorsea()
        {
            string word;
            Dictionary<string, string> morse = new Dictionary<string, string>();
            morse.Add("A", ".-");
            morse.Add("B", "-...");
            morse.Add("C", "-.-.");
            morse.Add("D", "-..");
            morse.Add("E", ".");
            morse.Add("F", ".-..");
            morse.Add("G", "--.");
            morse.Add("H", "....");
            morse.Add("I", "..");
            morse.Add("J", ".---");
            morse.Add("K", "-.-");
            morse.Add("L", "..-.");
            morse.Add("M", "--");
            morse.Add("N", "-.");
            morse.Add("O", "---");
            morse.Add("P", ".--.");
            morse.Add("Q", "--.-");
            morse.Add("R", ".-.");
            morse.Add("S", "...");
            morse.Add("T", "-");
            morse.Add("U", "..-");
            morse.Add("V", "...-");
            morse.Add("W", ".--");
            morse.Add("X", "-..-");
            morse.Add("Y", "-.--");
            morse.Add("Z", ".--..");

            List<string> words = new List<string>();
            word = Console.ReadLine();
            while (!string.IsNullOrEmpty(word))
            {
                words.Add(word);
                word = Console.ReadLine();
            }
            foreach (var model in words)
            {
                for (int i = 0; i < model.Length; i++)
                {
                    if (morse.ContainsKey(model[i].ToString().ToUpper()))
                    {
                        var result = morse.First(x => x.Key == model[i].ToString().ToUpper());

                        Console.Write("{0}/",result.Value);
                    }
                    if (model[i].ToString() == " ")
                    {
                        Console.Write("/");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
