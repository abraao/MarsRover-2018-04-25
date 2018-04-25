using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class MarsRover
    {
        private Position _position;
        private readonly Directions _dir;


        public MarsRover(Position position, Directions dir)
        {
            this._position = position;
            _dir = dir;
        }

        public Position CurrentPosition => _position;
        public Directions CurrentDirection => _dir;

        public void AddCommands(Command[] commandArray)
        {
            
        }
    }
}
