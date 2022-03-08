using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Strategy
{
    public class CompanyVisitStrategy : IVisitStrategy
    {
        public decimal CalculateCostFor(VisitS visit)
        {
            return visit.VisitDuration * visit.PricePerHour * (1 - visit.Discount);
        }
    }
}
