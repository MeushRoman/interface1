using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Ab : A, ISqrSqre
    {
        public int Sqr(int x)
        {
            return x * x;
        }

        public int Sqrt(int x)
        {
            return (int)Math.Sqrt((double)x);
        }
    }
}
