using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        private int _Width;
        private int _Height;
        private Player _Player;
        private IMazeObject[,] _MazeObjectsArray;
        public Maze(int Width,int Height)
        {
            _Width = Width;
            _Height = Height;
            _MazeObjectsArray= new IMazeObject[Width,Height];
            _Player= new Player() 
            { 
               X=1,
               Y=1
            };
        }

        public void DrawMaze()
        {
             Console.Clear();
            for (int y = 0; y < _Height; y++)
            {

                for (int x = 0; x < _Width; x++)
                {
                    if (x == _Width - 1&& y == _Height - 1)
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || y == _Height-1 || x == _Width-1)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x== _Player.X && y==_Player.Y) 
                    {
                        Console.Write(_Player.Icon);
                    }
                    else if(x%3==0 && y % 3 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);

                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);

                    }
                    
                    else
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }

            }
        public void MovePlayer()
        {
            ConsoleKeyInfo userInput= Console.ReadKey();
            ConsoleKey key = userInput.Key;

            switch (key) { 
            
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0,-1);
                    break;

                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;

                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                
                    /*default:
                    Console.WriteLine();
                    break;*/
            }
        }
        private void UpdatePlayer(int dx,int dy) 
        {
           var newX=_Player.X+dx;
            var newY = _Player.Y + dy;
            if (newX < _Width && newX >= 0 && newY < _Height && newY >= 0 && _MazeObjectsArray[newX,newY].IsSolid==false) { 
            
                _Player.X = newX;
                _Player.Y = newY;
                DrawMaze(); 
                
              
            }
        
            }
    }
}
