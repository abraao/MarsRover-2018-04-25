using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsRover.UnitTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void have_initial_position()
        {
            var position = new Position(1.1f, 10.2f);
            var rover = new MarsRover(position);

            Assert.IsNotNull(rover.CurrentPosition);
        }
    }
}