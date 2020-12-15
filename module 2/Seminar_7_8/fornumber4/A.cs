using System;

namespace ClassLibrary1
{
    public class A
    {
        private int a;

        public A(int a) => this.a = a;

        public virtual void GetA() => Console.WriteLine(a);
    }
}
