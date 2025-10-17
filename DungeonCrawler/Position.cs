namespace DungeonCrawler
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Position position)
        {
            return X == position.X && Y == position.Y;
        }
    }
}


