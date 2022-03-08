using System;

namespace FactoryVsStrategy.Factory
{
    public abstract class Visit
    {
        public Visit(DateTime visitDate, int visitDuration)
        {
            VisitDate = visitDate;
            VisitDuration = visitDuration;
        }
        public DateTime VisitDate { get; set; }
        public int VisitDuration { get; set; }

        public virtual decimal CalculateCost()
        {
            return 0;
        }
    }

 

}
