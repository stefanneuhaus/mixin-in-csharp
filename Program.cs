using System;

class Singer
{
    public void Sing()
    {
        Console.WriteLine("la la LAAA ...");
    }
}

class Drinker
{
    public void Drink()
    {
        Console.WriteLine("*sip*");
    }
}

/*
 * !! no valid C# code --- does not compile !!
 *
 * error CS1721: Class 'Bird' cannot have multiple base classes: 'Singer' and 'Drinker'
 */
class Bird : Singer, Drinker { }

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.Sing();
        bird.Drink();
    }
}