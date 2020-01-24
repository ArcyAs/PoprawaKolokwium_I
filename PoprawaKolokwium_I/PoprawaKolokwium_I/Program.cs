using System;

namespace PoprawaKolokwium_I
{
    class Program
    {
        static void Pierwsze()
        {
            int wynik = 0;
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
            }
            Console.WriteLine("Wynik to: {0}" ,wynik);
        }
        static void Drugie()
        {
            double kwota = 0;
            double[] pomiary = {5.2,8.2,10.3,7.3,14.2,14.9,13.2,11.2,10.3,11.8,13.2,11.1};
            Console.WriteLine(pomiary[0]);
            double prognozowaneZuzycie = pomiary[0]*12;
            double prognozowanaKwota = prognozowaneZuzycie * 1.4;
            for (int i = 0; i < pomiary.Length-1 ; i++)
            {
                kwota=+ kwota+ pomiary[i] * 1.4;
            }

            double roznica = prognozowaneZuzycie - kwota;
            Console.WriteLine("Prognozowane zuzycie to: {0}" ,prognozowaneZuzycie);
            Console.WriteLine("Prognozowana kwota to: {0}", prognozowanaKwota);
            Console.WriteLine("Kwota rzeczywista to: {0}", kwota);
            Console.WriteLine("Roznica kwoty prognozowanej i rzeczywistej to: {0}", roznica);
            
            
        }
        
                static void Main(string[] args)
        {
            Pierwsze();
            Drugie();
        }
    }
}