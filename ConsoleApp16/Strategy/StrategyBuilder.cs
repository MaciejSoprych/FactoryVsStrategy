using FactoryVsStrategy.Strategy;

namespace FactoryVsStrategy.Strategy
{
    public static class StrategyBuilder
    {
        public static decimal BuildStrategy(VisitS visitS)
        {
            if(visitS.VisitType == "N")
            {
                visitS.VisitStrategy = new NfzVisitStrategy();
            }
            else if (visitS.VisitType == "P")
            {
                visitS.VisitStrategy = new PrivateVisitStrategy();
            }
            else if (visitS.VisitType == "C")
            {
                visitS.VisitStrategy = new CompanyVisitStrategy();
            }

            return visitS.CalculateCost();
        }
    }
}
