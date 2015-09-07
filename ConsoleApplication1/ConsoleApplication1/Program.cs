using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin a = new Coin("GoldCoin", 45.20, 50.10, "1989/09/09");
            Gold b = new Gold("99% gold", 123.00, 150.10, "2010/09/07");
            Antique c = new Antique("Song Dynasty vase(sham)", 2000.00, 2100, "2013/08/05");
            Console.WriteLine("{0}", a.DateAcquired());
            Investments.ListInvestments();

            Console.WriteLine(Investments.TotalValue());
            Console.WriteLine(Investments.TotalProfits());
        }
    }
}
