using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp
{
    public class Class1
    {
        private int xxx;
        public Class1(int x = 0)
        {
            xxx = x;
        }

        public int X
        {
            get { return xxx; }
        }
    }
}
