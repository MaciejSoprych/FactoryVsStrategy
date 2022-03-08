using System;

namespace FactoryVsStrategy.Factory
{
    public class VisitFactory 
    {
        public Visit Create (string type, DateTime visitDate, int duration, decimal pricePerHour, decimal discount)
        {
            switch (type)
            {
                case "N": return new NfzVisit(visitDate, duration);
                case "P": return new PrivateVisit(visitDate, duration, pricePerHour);
                case "C": return new CompanyVisit(visitDate, duration, pricePerHour, discount);
                default:
                    throw new NotSupportedException();
            }
        }
    }

 
}
