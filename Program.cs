using System;
using Drinker;
using Singer;

class Bird : MSinger, MDrinker
{
    public Bird()
    {
        this.SetFavouritePhrase("*chirp*");
        this.SetDrinkingSound("*sip*");
    }
}

class RockStar : MSinger, MDrinker
{
    public RockStar()
    {
        this.SetFavouritePhrase("la la LAAA ...");
        this.SetDrinkingSound("*slurp* *slurp*");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Bird:");
        Bird bird = new Bird();
        bird.Sing();
        bird.Drink();

        Console.WriteLine("\n-- RockStar:");
        RockStar star = new RockStar();
        star.SetFavouritePhrase("I don't wanna live forever ... \x266A\x266C \U0001F918");
        star.Sing();
        star.Drink();

        Console.WriteLine("\n-- Metal God:");
        RockStar metalGod = new RockStar();
        metalGod.SetFavouritePhrase("This is a Painkiller ...");
        metalGod.Sing();

        Console.WriteLine("\n-- Duet:");
        metalGod.Sing();
        star.Sing();
    }
}