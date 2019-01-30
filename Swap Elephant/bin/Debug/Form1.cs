using System.Windows.Forms;

namespace Swap_Elephant
{
    public partial class Form1 : Form
    {   
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            {
                name = "Lucinda",
                EarSize = 33
            };
            lloyd = new Elephant()
            {
                name = "Lloys",
                EarSize = 35
            };
        }

        private void bntLloyd_Click(object sender, System.EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void bntLucinda_Click(object sender, System.EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void bntSwap_Click(object sender, System.EventArgs e)
        {
/*holder é um referência da classe quando usar o new é uma nova instância*/
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obj swapped");
        }

        private void bntTellMe_Click(object sender, System.EventArgs e)
        {
            lloyd.TellMe("Olá", lloyd);
        }

        private void bntSpeakTo_Click(object sender, System.EventArgs e)
        {
            lucinda.SpeakTo("sou outro", lloyd);
        }
    }
}
