﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Add(1, 2, 3);//来自Child类
            c.Add(4, 5);//来自Parent类
        }
    }
}
