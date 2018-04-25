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

        public MarsRover(Position position)
        {
            this._position = position;
        }

        public Position CurrentPosition => _position;
    }
}
