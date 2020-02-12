using System;
using System.Runtime.CompilerServices;

namespace PoprawaKolokwium_2_last
{
    public interface IDrukarka
    {
        public static void Drukuj(string cos)
        {
            Console.WriteLine("Drukowanie");
        }
    }
}