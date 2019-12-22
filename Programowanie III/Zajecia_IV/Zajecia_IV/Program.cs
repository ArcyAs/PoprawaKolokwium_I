using System;

namespace Z4
{
    class Program
    {
        static int[] Kopiuj(int[] tab)
        {
            int[] nova = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                nova[i] = tab[i];
                
            }

            return nova;
        }
        
        static void Main(string[] args)
        {
           

            int[] tab1 = { 1, 2, 3 };
           
            int[] tab2 = Kopiuj(tab1);


            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab2[i] + ",");
            }
            Console.WriteLine();

            int[] x = { 1, 2, 3, 4, 5, 6 };
            int[] y = new int [x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i];

            }

            x[2] = 100;

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ",");

            }
            
            Console.ReadLine();
        }
    }
}
