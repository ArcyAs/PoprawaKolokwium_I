using System;
 
namespace Zjazd_nr_8
{
    class Program
    {
        
        class Printer
        {
            public event EventHandler<OutOfPaperEventArgs> Out_of_paper;
            int paper_count;
 
 
            public Printer(int paper_count)
            {
                this.paper_count = paper_count;
            }
            
            private void OutOfPaperEvent(object sender, EventArgs args)
            {
                Console.WriteLine("Printer out of paper");
            }
            public void Print(int n)
            {
                if ( paper_count == 0)
                {
                    Out_of_paper?.Invoke(this,
                        new OutOfPaperEventArgs(n));
                    return;
                }
                else
                {
                    paper_count --;
                    Console.WriteLine("{0} Pages print...", n);
                }
            }
 
        }
        public class OutOfPaperEventArgs : EventArgs
        {
            int page_number;
            public OutOfPaperEventArgs(int pageNumber)
            {
                this.page_number = page_number;
 
            }
 
        }
 
        static void Main(string[] args)
        {
            bool printerOk = true;
            var printer = new Printer(100);
            printer.Out_of_paper += Out_of_Paper2;
 
            for (int i = 1; i < 105; i++)
            {
 
                printer.Print(i);
                if(!printerOk)
                {
                    return;
                }
            
            }
 
 
        }
        static void Out_of_Paper2(object sender, EventArgs args)
        {
            Console.WriteLine("Brak papieru !!!");
 
        }
 
    }
 
}