using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    public class RoverMoveSteps
    {
        private Rover rover;

        [Given(@"Rover is in plateau at \((\d+),(\d+)\) co-ordinates and facing a ([NEWS]{1})")]
        public void GivenRoverIsInPlateauAtCo_OrdinatesAndFacing(int x, int y, string direction)
        {
            rover = new Rover();
            Point point = new Point(x, y);
            rover.Position = point;
            rover.Direction = direction;
        }

        [When(@"the rover moves")]
        public void WhenTheRoverMoves()
        {
            rover.Move();
        }

        [Then(@"the rover reaches new position \((\d+),(\d+)\) in the same ([NEWS]{1}).")]
        public void ThenTheRoverReachesNewPositionInTheSame(int m, int n, string direction)
        {
            rover.Direction.Should().Be(direction);
            rover.Position.Should().Be(new Point(m, n));
        }        
        [Then(@"the rover falls out of the plateau")]
        public void ThenTheRoverFallsOutOfThePlateau()
        {
            throw new PendingStepException();
        }
    }
}
