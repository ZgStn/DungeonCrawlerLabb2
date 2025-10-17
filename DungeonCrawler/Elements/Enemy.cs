namespace DungeonCrawler.Elements
{
    public abstract class Enemy : LivingElement
    {
        public Enemy(Position position, char symbol, ConsoleColor color)
            : base(position, symbol, color)
        {

        }

        public abstract void Update(Player player, LevelData levelData);

        public override bool ShouldAttack(LivingElement target)
        {
            return target is Player;
        }
    }
}
