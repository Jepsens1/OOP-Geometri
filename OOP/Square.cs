using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square
    {
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public Square()
        {
            a = 7;
        }
        public int OmkredsMethod()
        {
            return 4 * a;
        }
        public int ArealMethod()
        {
            return a * a;
        }

    }
}
