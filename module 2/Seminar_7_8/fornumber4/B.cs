using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class B:A
    {
        private int m;

        public B(int a) : base(a) => m = a;

        public override void GetA() => Console.WriteLine(m+4);
    }
}
