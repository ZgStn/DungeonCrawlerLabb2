namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            LevelData levelData = new LevelData();
            levelData.Load("Level1.txt");

            GameLoop game = new GameLoop(levelData);
            game.Run();
        }
    }
}
