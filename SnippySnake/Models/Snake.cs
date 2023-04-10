using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
    public class Snake
    {
        public List<Point> Body { get; set; }
        public Point Direction { get; set; }
        public bool IsDead { get; set; }

        public Snake()
        {
            Body = new List<Point>();
            Body.Add(new Point(0, 0)); // initial starting position
            Direction = new Point(1, 0); // initial direction (right)
            IsDead = false;
        }

        public void Move()
        {
            // add new head to snake
            Point newHead = new Point(Body[0].X + Direction.X, Body[0].Y + Direction.Y);
            Body.Insert(0, newHead);

            // remove tail of snake
            Body.RemoveAt(Body.Count - 1);
        }

        public void ChangeDirection(Point newDirection)
        {
            // prevent snake from reversing direction on itself
            if (Body.Count > 1 && newDirection.X != -1 * Direction.X && newDirection.Y != -1 * Direction.Y)
            {
                Direction = newDirection;
            }
        }

        public void CheckCollisions(int boardWidth, int boardHeight, List<Point> walls, List<Point> tokens)
        {
            // check for collision with game board walls
            if (Body[0].X < 0 || Body[0].X >= boardWidth || Body[0].Y < 0 || Body[0].Y >= boardHeight)
            {
                IsDead = true;
            }

            // check for collision with game board walls
            foreach (Point wall in walls)
            {
                if (Body[0].Equals(wall))
                {
                    IsDead = true;
                }
            }

            // check for collision with tokens
            foreach (Point token in tokens)
            {
                if (Body[0].Equals(token))
                {
                    Body.Add(Body[Body.Count - 1]); // add new segment to body
                    tokens.Remove(token); // remove token from list of available tokens
                    break; // exit loop after first collision detected
                }
            }
        }
    }

}
