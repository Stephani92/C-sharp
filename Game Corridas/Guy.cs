using System.Windows.Forms;

namespace Game_Corridas
{
    class Guy
    {
        public string Name;
        public Bet MyBet = new Bet();
        public decimal Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " tem $ " + Cash; 
            MyLabel.Text = Name + MyBet.GetDescrition();
        }
        public void ClearBeat()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }
        public bool PlaceBet(decimal Amount, decimal Dog)
        {
            if (Cash >5)
            {
                MyBet.Dog = Dog;
                MyBet.Amount = Amount;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void Collect (int Winner)
        {
            this.Cash = MyBet.PayOut(Winner);
        }
    }
}
