using System;
using System.Runtime.CompilerServices;

namespace Singer
{
    interface MSinger { }

    static class SingerExtension
    {
        class State
        {
            public string FavouritePhrase;
        }

        static readonly ConditionalWeakTable<MSinger, State> States = new ConditionalWeakTable<MSinger, State>();

        public static void Sing(this MSinger singer)
        {
            string phrase = singer.GetFavouritePhrase();
            Console.WriteLine(phrase);
        }

        public static void SetFavouritePhrase(this MSinger singer, string favouritePhrase)
        {
            States.GetOrCreateValue(singer).FavouritePhrase = favouritePhrase;
        }

        static string GetFavouritePhrase(this MSinger singer)
        {
            return States.GetOrCreateValue(singer).FavouritePhrase;
        }
    }
}