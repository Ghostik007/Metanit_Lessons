using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class OverLoadOperators_30
    {
        public int Value { get; set; }
        public static OverLoadOperators_30 operator +(OverLoadOperators_30 a, OverLoadOperators_30 b)
        {
            return new OverLoadOperators_30 { Value = a.Value + b.Value };
        }
        public static bool operator >(OverLoadOperators_30 a, OverLoadOperators_30 b)
        {
            if(a.Value > b.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(OverLoadOperators_30 a, OverLoadOperators_30 b)
        {
            if (a.Value < b.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
