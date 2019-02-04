using System;
using System.Windows.Forms;

namespace Game_Corridas
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        

        public Form1()
        {
            InitializeComponent();

            lblMinBet.Text = "5 bucks";

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = new Greyhound() { Randomizer = new Random() };
            }

            

            dogs[0].MyPictureBox = pictureBox2;
            dogs[0].StatingPosition = -2;

            dogs[1].MyPictureBox = pictureBox3;
            dogs[1].StatingPosition = 68;

            dogs[2].MyPictureBox = pictureBox4;
            dogs[2].StatingPosition = 138;

            dogs[3].MyPictureBox = pictureBox5;
            dogs[3].StatingPosition = 216;


            //Inst Guys
            guys[0] = new Guy()
            {
                Name = "Joe",
                MyBet = new Bet(),
                Cash = 100,
                MyRadioButton = rdioJoe,
                MyLabel = lblJoe
            };

            guys[1] = new Guy()
            {
                Name = "Bob",
                MyBet = new Bet(),
                Cash = 80,
                MyRadioButton = rbtnBob,
                MyLabel = lblBob
            };

            guys[2] = new Guy()
            {
                Name = "Al",
                MyBet = new Bet(),
                Cash = 90 ,
                MyRadioButton = rbntAl,
                MyLabel = lblAl
            };

            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();

        }




        private void rdioJoe_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[0].Name;
            numUpDoenBet.Maximum = guys[0].Cash;
        }

        private void rbtnBob_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[1].Name;
            numUpDoenBet.Maximum = guys[1].Cash;
        }

        private void rbntAl_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = guys[2].Name;
            numUpDoenBet.Maximum = guys[2].Cash;
        }

        private void bntBet_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Joe")
            {
                guys[0].MyBet.Bettor = guys[0];
                guys[0].PlaceBet(numUpDoenBet.Value, NumUpDownDog.Value);
                guys[0].UpdateLabels();
            }
            if (label2.Text == "Bob")
            {
                guys[1].MyBet.Bettor = guys[1];
                guys[1].PlaceBet(numUpDoenBet.Value, NumUpDownDog.Value);
                guys[1].UpdateLabels();                
            }
            if (label2.Text == "Al")
            {
                guys[2].MyBet.Bettor = guys[2];
                guys[2].PlaceBet(numUpDoenBet.Value, NumUpDownDog.Value);
                guys[2].UpdateLabels();
            }
        }

        private void bntRun_Click(object sender, EventArgs e)
        {
            bool[] resulRun = new bool[4];


            for (int i = 0; i < dogs.Length; i++)
            {
                resulRun[i] = dogs[i].Run();
            }


            if (resulRun[0])
            {
                MessageBox.Show("ok 1");
            }
            if (resulRun[1])
            {
                MessageBox.Show("ok 2");
            }
            if (resulRun[2])
            {
                MessageBox.Show("ok 3");
            }
            if (resulRun[3])
            {
                MessageBox.Show("ok 4");
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartingPosition();                
            }
            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].ClearBeat();
            }
            
        }
    }
}
