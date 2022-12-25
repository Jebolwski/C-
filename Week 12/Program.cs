using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arl = new ArrayList();

        arl.Add("messi");
        arl.Add("Ronaldo");
        arl.Add(new Goat());
        foreach(object o in arl)
        {
            Console.Write("{0} ",o);
        }
        Console.WriteLine("\n=================");
        for(int i = 0; i < 20; i++)
        {
            Random rand = new Random();
            arl.Add(rand.Next(0, 30));
        }
        foreach (object o in arl)
        {
            Console.Write("{0} ", o);
        }
        Console.WriteLine("\n=================");
        //arl.Sort();
        arl.Reverse();
        foreach (object o in arl)
        {
            Console.Write("{0} ", o);
        }
        Console.WriteLine("\n=================");
        Console.WriteLine(arl.Count);
        Console.WriteLine("=================");
        Console.WriteLine(arl.Capacity);
        Console.WriteLine("=================");
        arl.RemoveAt(4);
        foreach (object o in arl)
        {
            Console.Write("{0} ", o);
        }
        Console.WriteLine("\n=================");
        Ball ball = new Ball();
        ball.Go();
        FkdepLookingBall fkdepLookingBall = new FkdepLookingBall();
        fkdepLookingBall.Go();
        WorldCupBall worldCupBall = new WorldCupBall();
        worldCupBall.Go();
    }
}

class Goat
{
    public string name = "Leo Messi";
    public int age = 35;
    public int jersey_number = 10;

    public override string ToString()
    {
        return "("+this.name+" "+this.jersey_number+" "+this.age+")";
    }
}


class Ball
{
    public virtual void Go()
    {
        Console.WriteLine("Shoot!!!");
    }
}

class FkdepLookingBall : Ball
{
    public override void Go()
    {
        Console.WriteLine("Psssssssssss!!!");
    }
}

class WorldCupBall: Ball
{
    public override void Go()
    {
        Console.WriteLine("GOALLLLLLLLLLLLLLLLLL!!!");
    }
}