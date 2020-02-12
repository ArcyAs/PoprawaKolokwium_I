using System;

namespace PoprawaKolokwium_2_last
{
    public interface ISkaner
    {
        public static string Skanuj(string skanowanie)
        {
            Console.WriteLine("Skanowanie");
            return skanowanie;
        }
    }
}