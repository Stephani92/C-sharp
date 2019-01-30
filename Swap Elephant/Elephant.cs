using System.Windows.Forms;

namespace Swap_Elephant
{
    class Elephant
    {
        public string name { get; set; }

        public int EarSize { get; set; }

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", name + " says..");
        } 

        public void TellMe(string msg, Elephant WhoSaidIt)
        {
            MessageBox.Show(WhoSaidIt.name + " says: " + msg);
        }

        public void SpeakTo(string msg, Elephant whoToTalkTo)
        {
            this.TellMe(msg, whoToTalkTo);
        }
    }
}
