using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor consoleColor=ConsoleColor.White;
            string message = string.Empty;

            for (int i = 0; i <= 100; i++)
            {
                
                
             

                if (i % 3 == 0)
                {
                    consoleColor= ConsoleColor.Red;
                    message = "Invoice";

                    if(i%5==0)
                    {
                        consoleColor = ConsoleColor.DarkGray;
                        message = "InvoiceCloud";
                    }

                }

                if (i % 5 == 0)
                {
                    consoleColor = ConsoleColor.Green;
                    message = "Cloud";

                    if (i % 3 == 0)
                    {
                        consoleColor = ConsoleColor.DarkGray;
                        message = "InvoiceCloud";
                    }

                }

                if ((i%3!=0)&&(i%5!=0))
                {
                   consoleColor = ConsoleColor.Blue;
                    message = i.ToString();
                }
                Console.ForegroundColor = consoleColor;
                System.Console.WriteLine(message);
            }
                System.Console.ReadLine();
        }

      

       
    }
}
