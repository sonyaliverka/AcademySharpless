#region Task_1
Shape ball = new Ball(name: "Ball", radius: 9);
Shape pyramid = new Pyramid(name: "Pyramid", height: 7, square: 29);
Shape cylinder = new Cylinder(name: "Cylinder", radius: 6, height: 8);


abstract class Shape
{
    private string Name;
    public abstract double Volume();

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Ball : Shape
{
    private double Radius;

    public Ball(string name, double radius) : base(name)
    {
        Radius = radius;
    }
    public override double Volume()
    {
        return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
    }
}

class Pyramid : Shape
{
    private double Height;
    private double Square;

    public Pyramid(string name, double height, double square) : base(name)
    {
        Height = height;
        Square = square;
    }
    public override double Volume()
    {
        return 1 / 3 * Square * Height;
    }
}

class Cylinder : Shape
{
    private double Height;
    private double Radius;

    public Cylinder(string name, double height, double radius) : base(name)
    {
        Height = height;
        Radius = radius;
    }
    public override double Volume()
    {
        return Math.PI * Math.Pow(Radius, 2) * Height;
    }
}

#endregion
//#region Task_2

//Student mob = new("Mob", 14);
//mob.Print();

//struct Student
//{
//    public string name;
//    public int age;

//    public Student(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public void Print()
//    {
//        Console.WriteLine($"Name: {name}  Age: {age}");
//    }
//}
//#endregion