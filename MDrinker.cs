using System;

namespace Drinker
{
    interface MDrinker { }

    static class DrinkerExtension
    {
        public static void Drink(this MDrinker drinker)
        {
            Console.WriteLine("*sip*");
        }
    }
}