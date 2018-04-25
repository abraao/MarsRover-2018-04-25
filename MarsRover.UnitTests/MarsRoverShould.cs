using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace MarsRover.UnitTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void have_initial_position()
        {
            var position = new Position(1.1f, 10.2f);
            var rover = new MarsRover(position, Directions.North);

            Assert.IsNotNull(rover.CurrentPosition);
        }

        [Test]
        public void have_initial_direction()
        {
            Position position = _fixture.Create<Position>();
            MarsRover rover = new MarsRover(position, Directions.North);

            Assert.AreEqual(Directions.North, rover.CurrentDirection);
        }
    }
}