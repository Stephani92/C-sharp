namespace Cap_4
{
    class Stats
    {
        public int Total { get; set; }
        public int Missed { get; set; }
        public int Correct { get; set; }
        public int Accuracy { get; set; }

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Missed + Correct);
        }

    }
}
