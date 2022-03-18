using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming
{
    internal class GameUnit : Surface
    {
        public Position position { get; protected set; }

        public GameUnit(Position position)
        {
            this.position = position;   
        }
        public void Draw(Surface surface)
        {
            surface.DrawAt(GetImage(), position);
        }
        protected virtual char GetImage()
        {
            return ' ';
        }
    }
}
