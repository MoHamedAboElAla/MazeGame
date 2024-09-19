using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public interface IMazeObject
    {
       char Icon { get; } //The Shape of the Maze
       bool IsSolid {  get;  } //Movement Block

    }
}
