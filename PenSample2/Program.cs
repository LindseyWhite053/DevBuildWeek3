Pen gelpen = new Pen("green", 5.0, "Gel", "Medium");
gelpen.Print();

Pen feltPen = new Pen("blue", 4.0, "Felt", "Small");
feltPen.Print();

gelpen.Draw(5);
gelpen.Print();

gelpen.Draw(7); // Expect to see "Sorry, Not enough ink since the Ink Amount will go below 0
gelpen.Print();

Console.WriteLine(gelpen);

class Pen
{
    public string InkColor;
    public double Length;
    public string PointType;
    public string PointSize;
    public int InkAmount;

    public Pen(string _InkColor, double _Length, string _PointType, string _PointSize)
    {
        InkColor = _InkColor;
        Length = _Length;
        PointType = _PointType; 
        PointSize = _PointSize;
        InkAmount = 10;
    }

    public void Print()
    {
        Console.WriteLine("This pen:");
        Console.WriteLine($"    Color: {InkColor}   Length: {Length}    Type: {PointType}   Size: {PointSize}   Amount: {InkAmount}");
    }

    public void Draw(int lineLength)
    {
        if (lineLength > InkAmount)
        {
            Console.WriteLine("Sorry, not enough ink for that!");
        } else
        {
            InkAmount -= lineLength;

            if (InkAmount < 0)
            {
                InkAmount = 0;
            }
        }
    }

    public void Refill()
    {
        InkAmount = 10;
    }

    public override string ToString()
    {
        return $"Color: {InkColor}  Length: {Length}    Type: {PointType}   Size: {PointSize}   Amount {InkAmount}";
    }
}