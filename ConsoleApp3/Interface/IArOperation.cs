﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IArOperation
    {
        int Sum();
        int Otr();
        int Prz();

    }

    public interface ISqrSqre
    {
        int Sqr(int x);
        int Sqrt(int x);
    }
}
