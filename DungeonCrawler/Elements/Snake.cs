namespace DungeonCrawler.Elements
{
    public class Snake : Enemy
    {
        public Snake(Position position)
            : base(position, 's', ConsoleColor.Green)
        {
            Name = "Snake";
            HP = 25;
            AttackDice = new Dice(3, 4, 2);
            DefenceDice = new Dice(1, 8, 5);
        }

        public override void Update(Player player, LevelData levelData)
        {
            double distance = Math.Sqrt(Math.Pow(player.Position.X - Position.X, 2) + Math.Pow(player.Position.Y - Position.Y, 2));
            if (distance > 2)
                return;

            int directionX = Position.X < player.Position.X ? -1 : (Position.X > player.Position.X ? 1 : 0);
            int directionY = Position.Y < player.Position.Y ? -1 : (Position.Y > player.Position.Y ? 1 : 0);

            Move(directionX, directionY, levelData);
        }
    }
}

