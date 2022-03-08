using System;

namespace ConsoleApp16
{
    public abstract class Visit
    {
        public Visit(DateTime visitDate, decimal visitDuration)
        {
            VisitDate = visitDate;
            VisitDuration = visitDuration;
        }
        public DateTime VisitDate { get; set; }
        public decimal VisitDuration { get; set; }

        public virtual decimal CalculateCost()
        {
            return 0;
        }
    }

 

}
