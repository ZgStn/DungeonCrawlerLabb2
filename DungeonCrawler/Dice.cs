namespace DungeonCrawler
{
    public class Dice
    {
        private int numberOfDice;
        private int sidesPerDie;
        private int modifier;
        private Random random;

        public Dice(int numberOfDice, int sidesPerDie, int modifier)
        {
            this.numberOfDice = numberOfDice;
            this.sidesPerDie = sidesPerDie;
            this.modifier = modifier;

            random = new Random();
        }

        public int Throw()
        {
            int total = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                total += random.Next(1, sidesPerDie + 1);
            }

            return total + modifier;
        }


        public override string ToString()
        {
            return $"{numberOfDice}d{sidesPerDie}+{modifier}";
        }
    }
}
