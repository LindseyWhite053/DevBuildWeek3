//firstPen is an object that has four variables inside it. 
Pen firstPen = new Pen();
firstPen.InkColor = "blue";
firstPen.Length = 4.5;
firstPen.PointType = "Gel";
firstPen.PointSize = "Small";
firstPen.InkAmount = 5;

Console.WriteLine(firstPen.InkColor);
Console.WriteLine(firstPen.Length);
Console.WriteLine(firstPen.PointType);
Console.WriteLine(firstPen.PointSize);
Console.WriteLine(firstPen.InkAmount);


Console.WriteLine("Let's draw with first pen!");
firstPen.Draw();
Console.WriteLine($"The ink amount of the first pen is now {firstPen.InkAmount}");

Console.WriteLine();

Pen secondPen = new Pen();
secondPen.InkColor = "red";
secondPen.Length = 4.5;
secondPen.PointType = "BallPoint";
secondPen.PointSize = "Medium";
secondPen.InkAmount = 2;

Console.WriteLine(secondPen.InkColor);
Console.WriteLine(secondPen.Length);
Console.WriteLine(secondPen.PointType);
Console.WriteLine(secondPen.PointSize);
Console.WriteLine(secondPen.InkAmount);

Console.WriteLine("Let's draw with the second pen!");
secondPen.Draw();
secondPen.Draw();

Console.WriteLine($"The ink amount of the second pen is now {secondPen.InkAmount}");
Console.WriteLine($"The ink amount of the first pen is still {firstPen.InkAmount}");


secondPen.Refill();
Console.WriteLine($"The ink amount of the second pen is now {secondPen.InkAmount}");

Console.WriteLine();
Console.WriteLine("Let's refil firstPen with green ink.");
firstPen.Refill("green");
Console.WriteLine($"The first pen now has {firstPen.InkColor} ink");

Console.WriteLine();
Pen thirdPen = new Pen();
Console.WriteLine(thirdPen.InkAmount);

Console.WriteLine();
Pen fourthPen = new Pen("green");
Console.WriteLine(fourthPen.InkColor);

class Pen
{
    //member variables
    public string InkColor;
    public double Length;
    public String PointType;
    public string PointSize;
    public int InkAmount;

    //Initializer/constructor as your first method. Does not require a return type. The method will match the class name.
    //Default constructor
    public Pen()
    {
        InkAmount = 10;
        InkColor = "black";
    }

    //Constrcutor that includes parameters. 
    public Pen(string _InkColor)
    {
        InkColor = _InkColor;
        InkAmount = 10;
    }

    //Methods or object functionality
    public void Draw()
    {
        if (InkAmount > 0)
        {
            InkAmount--;
        }

    }

    public void Refill()
    {
        InkAmount = 10;
    }

    // Let's add another Refil function that lets us specify ink color
    public void Refill(string newColor)
    {
        InkColor = newColor;
        InkAmount = 10;
    }
} 





