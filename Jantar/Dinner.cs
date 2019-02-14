namespace Jantar
{
    class Dinner
    {
        public const int ConstFoodPerOfPeople = 25;
        public int NumberofPeople { get; set; }
        public decimal CostOfDecorations { get; set; }
        public decimal CostOfDrink { get; set; }
        public bool fancyDecorations { get; set; }
        public bool HealthyOpt { get; set; }

        public Dinner(int NumberofPeople, bool fancyDecorations, bool HealthyOpt)
        {
            this.NumberofPeople = NumberofPeople;
            this.fancyDecorations = fancyDecorations;
            this.HealthyOpt = HealthyOpt;
        }


        public void CalculationCostOfDecorations( bool fancy)
        {
            if (fancy)
            {
                this.CostOfDecorations = (NumberofPeople * 15.00M) +50M;
            }
            else
            {
                this.CostOfDecorations = (NumberofPeople * 7.50M) + 30M;
            }
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                this.CostOfDrink = 5.00M;
            }
            else
            {
                this.CostOfDrink = 20.00M;
            }
        }

        public virtual decimal CalculateCost(bool healthyOption)
        {
            decimal totalCusto = CostOfDecorations + 
                ((CostOfDrink + ConstFoodPerOfPeople) * NumberofPeople);

            if (healthyOption)
            {
                return totalCusto * .95M;
            }
            else
            {
                return totalCusto;
            }

        }
    }
}
