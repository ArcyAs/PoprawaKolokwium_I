using System;

namespace PoprawaKolokwium_2_last
{
    public static class ExtensionMethod
    {
        public static void RazyDz(this int[]tablica)
        {
            int[] pomnozone = new int[tablica.Length];
            for (int i = 1; i < tablica.Length ; i++)
            {
                pomnozone[i] = tablica[i] *10;
                Console.WriteLine(pomnozone[i]);
            }
        }
    }
}