using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVsStrategy.Strategy
{
    public class VisitS
    {
        public string VisitType { get; set; }
        public DateTime VisitDate { get; set; }
        public int VisitDuration { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Discount { get; set; }
        public IVisitStrategy VisitStrategy { get; set; }

        public decimal CalculateCost()
        {
            return VisitStrategy.CalculateCostFor(this);
        }
    }
}
