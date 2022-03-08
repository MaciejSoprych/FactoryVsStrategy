using System;

namespace FactoryVsStrategy.Factory
{
    public class CompanyVisit : Visit
    {
        public CompanyVisit(DateTime visitDate, int visitDuration, decimal pricePerHour, decimal discount) : base(visitDate, visitDuration)
        {
            PricePerHour = pricePerHour;
            Discount = discount;
        }
        public decimal PricePerHour { get; set; }
        public decimal Discount { get; set; }

        public override decimal CalculateCost()
        {
            return VisitDuration * PricePerHour * (1-Discount);

        }
    }

 

}
