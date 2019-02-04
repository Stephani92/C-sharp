using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Game_Corridas
{
    class Greyhound
    {
        public int StatingPosition = 0;
        public int RaceTrackLength = 797;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        int[] espacos = {2,3,3,4,4,4,5,5,5,5,6,6,6,6,6,7,7,7,7,7,7,
            8,8,8,8,8,8,9,9,9,9,10,10,10,11,11,12};
        public string final;
        public int[] resulRandom = new int [300];


        public bool Run()
        {
            while (RaceTrackLength >= 0)
            {
                for (int i = 0; RaceTrackLength >= 0; i++)
                {
                    resulRandom[i] = espacos[Randomizer.Next(espacos.Length)];
                    this.RaceTrackLength -= resulRandom[i];
                    this.Location += resulRandom[i];
                    this.MyPictureBox.Location = new Point(this.Location, this.StatingPosition);
                    this.final = "loca: " + this.Location + " dist: " + RaceTrackLength;
                    Thread.Sleep(10);
                }
            }
            if (this.RaceTrackLength <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        public void TakeStartingPosition()
        {
            this.Location = 0;
            this.MyPictureBox.Location = new Point(this.Location, this.StatingPosition);
            this.RaceTrackLength = 797;
            this.final = "loca: " + this.Location + " dist: " + this.RaceTrackLength;
        }
    }
}
