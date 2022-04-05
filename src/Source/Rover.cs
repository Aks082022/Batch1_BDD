using System;

namespace MarsRovers
{
    class Rover
    {
        public string Direction { get; set; }

        public Point Position { get;  set; }

        public string ErrorMessage { get; set; }

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

        internal void Move()
        {
            if (Position.X == 0 && Position.Y == 0 && (Direction == "W" || Direction == "S"))
            {
                ErrorMessage = "Rover falls out";
            }
            else if (Direction == "S")
            {
                Position.Y = Position.Y - 1;
            }
            else if (Direction == "N")
            {
                Position.Y = Position.Y + 1;
            }
            else if (Direction == "W")
            {
                Position.X = Position.X - 1;
            }
            else if (Direction == "E")
            {
                Position.X = Position.X + 1;
            }
        }
    }
}