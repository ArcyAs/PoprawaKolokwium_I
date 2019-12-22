
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetodyNumeryczneIII
{
    
    class Program
    {

        static void WyswietlMacierz(double[,] a)
        {
            Console.WriteLine("Macierz wygląda tak:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        static double[,] WczytajMacierz()
        {
            double[] x = {1.5, 2, 2.5, 3.5, 3.8, 4.1};
            double[] y = {2, 5, -1, 0.5, 3, 7};
            double[,] a = new double[6, 5];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (j == 0)
                    {
                        a[i, j] = 1;
                    }
                    else if (j == 1)
                    {
                        a[i, j] = Convert.ToDouble(x[i]); 
                    }
                    else if (j == 2)
                    {
                        a[i, j] = Convert.ToDouble(Math.Pow(x[i], 2));
                    }
                    else if (j == 3)
                    {
                        a[i, j] = Convert.ToDouble(Math.Pow(x[i], 3));
                    }
                    else if (j == 4)
                    {
                        a[i, j] = Convert.ToDouble(y[i]);
                    }
                 
                    
                }
                
            }
            return a;
        }
        
        static void Main(string[] args)
        {
            int n= 5;
            //Console.WriteLine("Podaj ilość równań:");
            //n = Convert.ToInt32(Console.ReadLine());
            
            double[,] a = WczytajMacierz();
            WyswietlMacierz(a);

            for (int k = 0; k < n; k++)
            {
                double max = a[k, k];
                int r = k;
                for (int i = k; i < n; i++)
                {
                    if (Math.Abs(a[i, k]) > Math.Abs(max))
                    {
                        max = a[i, k];
                        r = i;
                    }
                }
                if (max == 0)
                {
                    Console.WriteLine("Macierz układu osobliwa");
                    return;
                }
                
                {
                    for (int j = k; j < n + 1; j++)
                    {
                        double temp = a[k, j];
                        a[k, j] = a[r, j];
                        a[r, j] = temp;

                    }
                    for (int j = k; j < n + 1; j++)
                    {
                        a[k, j] = a[k, j] / max;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        if (i == k) continue;
                        
                        {
                            double p = a[i, k];
                            for (int j = k; j < n + 1; j++)
                            {
                                a[i, j] = a[i, j] - p * a[k, j];
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Wynik:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a{0}= {1}", i + 1, a[i, n]);
            }


            Console.ReadLine();
        }
    }
}
