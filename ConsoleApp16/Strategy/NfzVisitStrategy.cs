﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Strategy
{
    public class NfzVisitStrategy : IVisitStrategy
    {
        public decimal CalculateCostFor(VisitS visit)
        {
            return 0.00m;
        }
    }
}
