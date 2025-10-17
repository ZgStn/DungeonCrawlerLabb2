namespace DungeonCrawler.Elements
{
    public class Rat : Enemy
    {
        private static Random randomGenerator = new Random();

        public Rat(Position position)
            : base(position, 'r', ConsoleColor.Red)
        {
            Name = "Rat";
            HP = 10;
            AttackDice = new Dice(1, 6, 3);
            DefenceDice = new Dice(1, 6, 1);
        }

        public override void Update(Player player, LevelData levelData)
        {
            int directionX = 0, directionY = 0;

            Direction direction = (Direction)randomGenerator.Next(4);

            switch (direction)
            {
                case Direction.Right: directionX = 1; break;
                case Direction.Left: directionX = -1; break;
                case Direction.Down: directionY = 1; break;
                case Direction.Up: directionY = -1; break;
            }

            Move(directionX, directionY, levelData);
        }
    }
}

