using System;

namespace ConsoleApp16
{
    public class CompanyVisit : Visit
    {
        public CompanyVisit(DateTime visitDate, decimal visitDuration, decimal pricePerHour, decimal discount) : base(visitDate, visitDuration)
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
