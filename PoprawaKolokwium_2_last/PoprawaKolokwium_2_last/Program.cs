using System;
using System.Collections.Generic;
using System.Linq;

namespace PoprawaKolokwium_2_last
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            List<Piosenka> playlista = new List<Piosenka>();
            playlista.Add(new Piosenka(){tytul = "pierwsza", autor = "pierwszy", dlugosc = new TimeSpan(30)});
            playlista.Add(new Piosenka(){tytul = "druga", autor = "drugi", dlugosc = new TimeSpan(20)});
            playlista.Add(new Piosenka(){tytul = "trzecia", autor = "trzeci", dlugosc = new TimeSpan(40)});
            foreach (var item in playlista)
            {
                Console.WriteLine($"{item.tytul}, {item.autor}, {item.dlugosc}");
            }

            var razem = playlista.Sum(x => x.dlugosc.Ticks);
            IOrderedEnumerable<Piosenka> poAutorze = playlista.OrderBy(x => x.autor);
            IOrderedEnumerable<Piosenka> poTytule = playlista.OrderBy(x => x.tytul);
            
            foreach (var VARIABLE in poAutorze)
            {
               // Console.WriteLine($"{item.tytul}, {item.autor}, {item.dlugosc}");
            }

            foreach (var VARIABLE in poTytule)
            {
               // Console.WriteLine($"{item.tytul}, {item.autor}, {item.dlugosc}");
            }
        
            int[] tablica = {1, 3, 5, 5, 8, 1, 9, 18, 9, 12};
        }
    }
        
}