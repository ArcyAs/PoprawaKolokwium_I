using System;

namespace PoprawaKolokwium_2_last
{
    public class IKopiarka : IDrukarka, ISkaner
    {
        public string kopiuj(string kopiowanie)
        {
            Console.WriteLine("Kopiowanie");
            return kopiowanie;
        }
    }
}