using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Investments
    {
        string name;
        double cost;
        double evalue;
        string dateAcquired;

        public Investments(string Name, double Cost, double EValue, string DateAcquired)
        {

            this.name = Name;
            this.cost = Cost;
            this.evalue = EValue;
            this.dateAcquired = DateAcquired;
            list.Add(this);
        }
        public Investments() : this("noName", 0.00, 0.00, "noDate")
        { }

        public abstract double Profits();


        public static List<Investments> list = new List<Investments>();
        public override string ToString()
        {
            return string.Format("Investment: {0}, {1}, {2},{3}", name, cost, evalue, dateAcquired);
        }

        public static void ListInvestments()
        {
            foreach (Investments i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static double TotalValue()
        {
            double totalValue = 0;
            foreach (Investments i in list)
            {
                totalValue = totalValue + i.evalue;
            }
            return totalValue;
        }

        public static double TotalProfits()
        {
            double totalProfits = 0;
            foreach (Investments i in list)
            {
                totalProfits = totalProfits + i.Profits();
            }
            return totalProfits;
        }

    }
}
