using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Strategy
{
    public interface IVisitStrategy
    {
        public decimal CalculateCostFor(VisitS visit);
    }
}
