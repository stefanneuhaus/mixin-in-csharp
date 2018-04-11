using System;

namespace Singer
{
    interface MSinger { }

    static class SingerExtension
    {
        public static void Sing(this MSinger singer)
        {
            Console.WriteLine("la la LAAA ...");
        }
    }
}