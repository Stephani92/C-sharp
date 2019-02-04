namespace Game_Corridas
{
    class Bet
    {
        public decimal Amount;
        public decimal Dog;
        public Guy Bettor;

        public string GetDescrition()
        {
            string MsgBet = " apostou " + Amount + " no # " + Dog;
            return MsgBet;
        }
        public decimal PayOut(int Winner)
        {
            if (Winner == Dog)
            {
               return +Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
