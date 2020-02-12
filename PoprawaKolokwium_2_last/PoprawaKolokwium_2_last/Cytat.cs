using System;

namespace PoprawaKolokwium_2_last
{
    public class Cytat
    {
        public void Deconstruct(out string autor, out string tytul, out DateTime dataWydania, out string miejsceWydania, out string wydawnictwo)
        {
            autor = this.autor;
            tytul = this.tytul;
            dataWydania = this.dataWydania;
            miejsceWydania = this.miejsceWydania;
            wydawnictwo = this.wydawnictwo;
        }

        public void Deconstruct(out string autor, out int dataWydania)
        {
            autor = this.autor;
            dataWydania = this.dataWydania.Year;
        }

        public string autor;
        public string tytul;
        public DateTime dataWydania;
        public string miejsceWydania;
        public string wydawnictwo;
    }
}