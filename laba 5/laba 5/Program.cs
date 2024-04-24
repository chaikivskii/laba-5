public abstract class Bird
{
    public int Age { get; set; }

    public Bird(int age)
    {
        Age = age;
    }

    public abstract void Display();
}

public class FlyingBird : Bird
{
    public int MaxFlightHeight { get; set; }

    public FlyingBird(int age, int maxFlightHeight) : base(age)
    {
        MaxFlightHeight = maxFlightHeight;
    }

    public override void Display()
    {
        Console.WriteLine($"Flying bird is {Age} years old and can fly up to {MaxFlightHeight} meters.");
    }
}

public class Eagle : FlyingBird
{
    public Eagle(int age, int maxFlightHeight) : base(age, maxFlightHeight) { }
}

public class Parrot : FlyingBird
{
    public Parrot(int age, int maxFlightHeight) : base(age, maxFlightHeight) { }
}

public class NonFlyingBird : Bird
{
    public int RunningSpeed { get; set; }

    public NonFlyingBird(int age, int runningSpeed) : base(age)
    {
        RunningSpeed = runningSpeed;
    }

    public override void Display()
    {
        Console.WriteLine($"Non-flying bird is {Age} years old and can run at {RunningSpeed} km/h.");
    }
}

public class Ostrich : NonFlyingBird
{
    public Ostrich(int age, int runningSpeed) : base(age, runningSpeed) { }
}

public class Penguin : NonFlyingBird
{
    public Penguin(int age, int runningSpeed) : base(age, runningSpeed) { }
}

class Program
{
    static void Main(string[] args)
    {
        var eagle = new Eagle(5, 2000);
        var parrot = new Parrot(2, 100);
        var ostrich = new Ostrich(3, 60);
        var penguin = new Penguin(1, 2);

        eagle.Display();
        parrot.Display();
        ostrich.Display();
        penguin.Display();
    }
}
