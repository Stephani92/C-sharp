using System;

namespace Jantar
{
    class Birth : Dinner
    {   
        public int CakeSize { get; set; }
        private String CakeWriting = "";

        public Birth(int NumberofPeople, bool fancyDecorations, bool HealthyOpt) : base(NumberofPeople, fancyDecorations, HealthyOpt)
        {
        }

        public string cakeWriting { get { return this.CakeWriting; }
                               set { int maxLeng;
                if (CakeSize == 8)
                {
                    maxLeng = 16;
                }
                else
                {
                    maxLeng = 40;
                }
                if (value.Length > maxLeng)
                {
                    if (maxLeng > this.CakeWriting.Length)
                    {
                        maxLeng = this.CakeWriting.Length;
                        this.CakeWriting = cakeWriting.Substring(0, maxLeng);
                    }
                }
                else
                {
                    this.CakeWriting = value;
                }
            }
        }
        
        public void CalculCakeSize()
        {
            if (NumberofPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        public override decimal CalculateCost(bool healthyOption)
        {
            decimal CostCake;

            if (CakeSize == 8)
            {
                CostCake = 40M + this.cakeWriting.Length * .25M;
            }
            else
            {
                CostCake = 75M + this.cakeWriting.Length * .25M;
            }
            return base.CalculateCost(healthyOption) + CostCake;
        }

    }
}
