using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Aa : A
    {
        public Aa(int z, int x, int y) : base(x, y)
        {
            this.z = z;
        }
        public int z { get; set; }

        public override int Sum()
        {
            return base.x + base.y + this.z;
        }
    }
}
