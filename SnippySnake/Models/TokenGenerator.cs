using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
    public static class TokenGenerator
    {
        private static readonly Random random = new Random();

        public static Token GenerateRandomToken(int minValue, int maxValue, int maxX, int maxY)
        {
            int value = random.Next(minValue, maxValue + 1);
            Point position = new Point(random.Next(maxX), random.Next(maxY));
            return new Token(value, position);
        }
    }
}
