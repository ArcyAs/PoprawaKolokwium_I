using System;

namespace PoprawaKolokwium_I
{
    class Program
    {
        static void Pierwsze()
        {
            int wynik;
            double x, maxX;
            Console.WriteLine("Podaj liczbe nr1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe nr2: ");
            maxX = Convert.ToDouble(Console.ReadLine());
            if(x <= 0.5*maxX)
            {
                wynik = 0;
            }
            else
            {
                x = (x/maxX)*100;
                wynik = 
            }
            Console.WriteLine(wynik);
        }
        static void Drugie()
        {
            double[] pomiary = {5.4,8.2,10.3,7.3,14.2,14.9,13.2,11.2,10.3,11.8,13.2,11.1};
            double prognozowaneZuzycie =  pomiary[1]*12;
            double prognozowanaKwota = prognozowaneZuzycie * 1.4;
            for (int i = 0; i < pomiary.Length ; i++)
            {
                double kwota =+ pomiary[i] * 1.4;
            }
            
            Console.WriteLine(prognozowaneZuzycie);
            Console.WriteLine(prognozowanaKwota);
            
            
            
        }
        
                static void Main(string[] args)
        {
            Pierwsze();
            Drugie();
        }
    }
}