using System;
using System.Windows.Forms;

namespace Cap_4
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        //MenuLbl


        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Gamer over");
                timer1.Stop();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                if (timer1.Interval > 250)
                {
                    timer1.Interval -= 7;
                }
                if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }
                diffProgressBar.Value = 800 - timer1.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            lblMenuCorrect.Text = "Correct: " + stats.Correct;
            lblMenuMissed.Text = "Correct: " + stats.Missed;
            lblTotal.Text = "Correct: " + stats.Total;
            lblAccruracy.Text = "Correct: " + stats.Accuracy;

        }

        


    }
}
