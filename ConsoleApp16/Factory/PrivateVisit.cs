using System;

namespace FactoryVsStrategy.Factory
{
    public class PrivateVisit : Visit
    {
        public PrivateVisit(DateTime visitDate, int visitDuration, decimal pricePerHour) : base(visitDate, visitDuration)
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
