using ConsoleApp16.Strategy;
using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("FactoryPattern");
            var visitFactory = new VisitFactory();
            string type = "P";
            DateTime visitDate = DateTime.Now; 
            decimal duration = 20.00m; 
            decimal pricePerHour = 200;
            decimal discount = 0.3m; ;
            var visit = visitFactory.Create(type, visitDate, duration, pricePerHour, discount);
            var costF = visit.CalculateCost();
            Console.WriteLine(costF);

            Console.WriteLine("StrategyPattern");
            var visitS = new VisitS();
            visitS.VisitType = type;
            visitS.VisitDate = visitDate;
            visitS.VisitDuration = duration;
            visitS.PricePerHour = pricePerHour;
            visitS.Discount = discount;
            var costS = StrategyBuilder.BuildStrategy(visitS);
            Console.WriteLine(costS);

        }


    }
}
