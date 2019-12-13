using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IzpitOOP
{
    // Every time you do new Random() it is initialized using the clock. 
    // This means that when you initiaize a lot of Randoms in a short period of time,
    // they will produce the same value. That is why this class is needed

    public static class StaticRandom
        {
            private static int seed;

            private static System.Threading.ThreadLocal<Random> threadLocal = new System.Threading.ThreadLocal<Random>
                (() => new Random(Interlocked.Increment(ref seed)));

            static StaticRandom()
            {
                seed = Environment.TickCount;
            }

            public static Random Instance { get { return new Random(Interlocked.Increment(ref seed)); } }
        }
    
}
