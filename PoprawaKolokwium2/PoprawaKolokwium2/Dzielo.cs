using System;

namespace PoprawaKolokwium2
{
    public abstract class Dzielo
    {
        public string nrKarty;
        public string tytul;

        public Dzielo(string nrKarty, string tytul)
        {
            this.nrKarty = nrKarty;
            this.tytul = tytul;
        }

        protected Dzielo()
        {
            throw new NotImplementedException();
        }

        public void Opis()
        {
            Console.WriteLine(nrKarty, tytul);
        }
    }

    public class Ksiazka : Dzielo
    {
        public string isbn;
        public int rokWydania;

        public void Opis()
        {
            Console.WriteLine(nrKarty, tytul, isbn, rokWydania);
        }
    }

    public class Czasopismo : Dzielo
    {
        public string issn;
        public int czestotliwosc;

        public void Opis()
        {
            Console.WriteLine(nrKarty, tytul, issn, czestotliwosc);  
        }
    }
}