using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IInvestment
    {
        double Cost();
        double EstimatedValue();
        //double Profits();
        string DateAcquired();
    }

    public class Coin : Investments, IInvestment
    {
        string name;
        double cost;
        double Evalue;
        string dateAcquired;

        public Coin(string Name, double Cost, double EValue, string DateAcquired) : base(Name, Cost, EValue, DateAcquired)
        {
            this.name = Name;
            this.cost = Cost;
            this.Evalue = EValue;
            this.dateAcquired = DateAcquired;

        }

        public double Cost()
        {
            return cost;
        }
        public double EstimatedValue()
        {
            return Evalue;
        }
        public override double Profits()
        {
            return (Evalue - cost);
        }
        public string DateAcquired()
        {
            return dateAcquired;
        }
    }

    public class Gold : Investments, IInvestment
    {
        string name;
        double cost;
        double Evalue;
        string dateAcquired;

        public Gold(string Name, double Cost, double EValue, string DateAcquired) : base(Name, Cost, EValue, DateAcquired)
        {
            this.name = Name;
            this.cost = Cost;
            this.Evalue = EValue;
            this.dateAcquired = DateAcquired;
        }

        public double Cost()
        {
            return cost;
        }
        public double EstimatedValue()
        {
            return Evalue;
        }
        public override double Profits()
        {
            return (Evalue - cost);
        }
        public string DateAcquired()
        {
            return dateAcquired;
        }
    }

    public class Antique : Investments, IInvestment
    {
        string name;
        double cost;
        double Evalue;
        string dateAcquired;

        public Antique(string Name, double Cost, double EValue, string DateAcquired) : base(Name, Cost, EValue, DateAcquired)
        {
            this.name = Name;
            this.cost = Cost;
            this.Evalue = EValue;
            this.dateAcquired = DateAcquired;
        }

        public double Cost()
        {
            return cost;
        }
        public double EstimatedValue()
        {
            return Evalue;
        }
        public override double Profits()
        {
            return (Evalue - cost);
        }
        public string DateAcquired()
        {
            return dateAcquired;
        }
    }


}
