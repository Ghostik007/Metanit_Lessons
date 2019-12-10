using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class Generics_36
    {
    }

    class Account<T>
    {
        public T id { get; set; }
        public int sum { get; set; }

    }

    class Transaction<U,V>
    {
        public U fromAccount { get; set; }
        public U toAccount { get; set; }
        public V code { get; set; }

        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
