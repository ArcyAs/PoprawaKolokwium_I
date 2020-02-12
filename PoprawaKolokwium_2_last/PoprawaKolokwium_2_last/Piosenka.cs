using System;

namespace PoprawaKolokwium_2_last
{
    public  class Piosenka
    {
        public string tytul;
        public string autor;
        public TimeSpan dlugosc;

        public Piosenka(string tytul, string autor, TimeSpan dlugosc)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.dlugosc = dlugosc;
        }

        public Piosenka()
        {
            throw new NotImplementedException();
        }
    }
}