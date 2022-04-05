﻿using FluentAssertions;
using NUnit.Framework;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {

        [Test]
        public void RoverTestInitiallize()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Direction.Should().Be("N");
            rover.Position.Should().Be(new Point(1,2));

        }

        [Test]
        public void RoverShouldTurnLeftFromNorth()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("W");
            rover.Position.Should().Be(new Point(1, 2));
        }

    [Test]
    public void RoverShouldTurnLeftFromEast()
    {
      Rover rover = new Rover();
      rover.Direction = "E";
      rover.Position = new Point(1, 2);
      rover.Turn("L");
      rover.Direction.Should().Be("N");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnLeftFromSouth()
    {
      Rover rover = new Rover();
      rover.Direction = "S";
      rover.Position = new Point(1, 2);
      rover.Turn("L");
      rover.Direction.Should().Be("E");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnLeftFromWest()
    {
      Rover rover = new Rover();
      rover.Direction = "W";
      rover.Position = new Point(1, 2);
      rover.Turn("L");
      rover.Direction.Should().Be("S");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnRightFromNorth()
    {
      Rover rover = new Rover();
      rover.Direction = "N";
      rover.Position = new Point(1, 2);
      rover.Turn("R");
      rover.Direction.Should().Be("E");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnRightFromEast()
    {
      Rover rover = new Rover();
      rover.Direction = "E";
      rover.Position = new Point(1, 2);
      rover.Turn("R");
      rover.Direction.Should().Be("S");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnRightFromSouth()
    {
      Rover rover = new Rover();
      rover.Direction = "S";
      rover.Position = new Point(1, 2);
      rover.Turn("R");
      rover.Direction.Should().Be("W");
      rover.Position.Should().Be(new Point(1, 2));
    }

    [Test]
    public void RoverShouldTurnRightFromWest()
    {
      Rover rover = new Rover();
      rover.Direction = "W";
      rover.Position = new Point(1, 2);
      rover.Turn("R");
      rover.Direction.Should().Be("N");
      rover.Position.Should().Be(new Point(1, 2));
    }

  }
}
