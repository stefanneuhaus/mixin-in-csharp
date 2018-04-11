using System;
using System.Runtime.CompilerServices;

namespace Drinker
{
    interface MDrinker { }

    static class DrinkerExtension
    {
        class State
        {
            public string DrinkingSound;
        }

        static readonly ConditionalWeakTable<MDrinker, State> States = new ConditionalWeakTable<MDrinker, State>();

        public static void Drink(this MDrinker drinker)
        {
            string sound = drinker.GetDrinkingSound();
            Console.WriteLine(sound);
        }

        public static void SetDrinkingSound(this MDrinker drinker, string drinkingSound)
        {
            States.GetOrCreateValue(drinker).DrinkingSound = drinkingSound;
        }

        static string GetDrinkingSound(this MDrinker drinker)
        {
            return States.GetOrCreateValue(drinker).DrinkingSound;
        }
    }
}