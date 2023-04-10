using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
   public class Token
    {
        public int Value { get; set; }
        public Point Position { get; set; }

        public Token(int value, Point position)
        {
            Value = value;
            Position = position;
        }
    }
}
