using System;
using System.Data;

namespace PoprawaKolokwium2
{
    public class Wiadomosc
    {
        public void Deconstruct(out string tresc, out DateTime data)
        {
            tresc = "";
            data = DateTime.Now;
            int dlugosc = tresc.Length;
            int roznica = Convert.ToInt32(DateTime.Now - data);
        }

        public void Deconstruct(out string tresc, out string autor, out DateTime data)
        {
            tresc = this.tresc;
            autor = this.autor;
            data = this.data;
        }

        public string tresc { get; set; }
        public string autor { get; set; }
        DateTime data { get; }

    }
}