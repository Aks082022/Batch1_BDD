using System;

namespace MarsRovers
{
  class Rover
  {
    public string Direction { get; internal set; }
    public Point Position { get; internal set; }

    internal void Turn(string turnDirection)
    {
      if (turnDirection == "L")
      {

        if (Direction == "N")
        {
          Direction = "W";
        }

        else if (Direction == "E")
        {
          Direction = "N";
        }

        else if (Direction == "W")
        {
          Direction = "S";
        }

        else if (Direction == "S")
        {
          Direction = "E";
        }
      }

      if (turnDirection == "R")
      {

        if (Direction == "N")
        {
          Direction = "E";
        }

        else if (Direction == "E")
        {
          Direction = "S";
        }

        else if (Direction == "W")
        {
          Direction = "N";
        }

        else if (Direction == "S")
        {
          Direction = "W";
        }
      }
    }
  }
}