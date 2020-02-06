using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace PoprawaKolokwium2
{
    public class Polaczenie
    {
        public int numer;
        public DateTime data;
        public TimeSpan czas;
        
        public Polaczenie(int numer, DateTime data, TimeSpan czas)
        {
            this.numer = numer;
            this.data = data;
            this.czas = czas;
        }

        static Random rand = new Random();
        static int numerTel = rand.Next(600000000, 999999999);

        private static DateTime dataPolaczenia =
            Convert.ToDateTime(RandomizerFactory.GetRandomizer(new FieldOptionsDateTime()));
        private static var dlugoscPolaczenia =
            RandomizerFactory.GetRandomizer(new FieldOptionsTimeSpan());
        static List<int> polaczenia = Enumerable.Range(1, 50).ToList();

        private static IEnumerable<Polaczenie> posegregowane = polaczenia.Select(
            x => new Polaczenie(numerTel, dataPolaczenia, dlugoscPolaczenia)
        );



    }
}