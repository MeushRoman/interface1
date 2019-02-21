using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class A : IArOperation
    {
        public int x { get; set; }
        public int y { get; set; }
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Otr()
        {
            return x - y;       
        }   

        public int Prz()
        {
            return x * y;
        }

        public virtual int Sum()
        {
            return x + y;
        }

        
    }
}
