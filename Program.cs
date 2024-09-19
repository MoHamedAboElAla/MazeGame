namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maze Game!");
            Console.WriteLine("Use Keyboard arrows to move the Player");
            Maze maze = new Maze(40, 20);
            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
        }
    }
}
