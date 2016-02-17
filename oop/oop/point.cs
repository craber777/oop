using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point( _x, _y, _sym );
    {
        x = _x;
        y = _y;
        sym = _sym;
    }


        public void Draw();
        {            
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
