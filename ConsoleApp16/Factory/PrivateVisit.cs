using System;

namespace ConsoleApp16
{
    public class PrivateVisit : Visit
    {
        public PrivateVisit(DateTime visitDate, decimal visitDuration, decimal pricePerHour) : base(visitDate, visitDuration)
        {
            PricePerHour = pricePerHour;
        }
        public decimal PricePerHour { get; set; }

        public override decimal CalculateCost()
        {
            return VisitDuration * PricePerHour;
            
        }
    }

 

}
