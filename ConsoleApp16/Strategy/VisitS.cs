using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Strategy
{
    public class VisitS
    {
        public string VisitType { get; set; }
        public DateTime VisitDate { get; set; }
        public decimal VisitDuration { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Discount { get; set; }
        public IVisitStrategy VisitStrategy { get; set; }

        public decimal CalculateCost()
        {
            return VisitStrategy.CalculateCostFor(this);
        }
    }
}
