using Shapes;
using System.Drawing;

Console.WriteLine("0 = circles");
Console.WriteLine("1 = triangles");
int selctor = int.Parse(Console.ReadLine());
if (selctor == 0) 
{
    Circles(); 
}
if (selctor == 1) 
{
    Triangles(); 
}
void Triangles()
{
    Triangle Trong = new Triangle(5.5, color: null);
    Triangle Trongle = new Triangle(10.4, "red");
    Triangle Tring = new Triangle(3, "pink");
    Triangle Tringle = new Triangle(3, "pink");
    bool p1 = false;
    bool p2 = false;
    bool p3 = false;
    bool p4 = false;
    if (p4)
    {
        Triangle.Description();
        Console.WriteLine($" Tring {Tring.Catagorize()}");
        Console.WriteLine($" Tringle {Tringle.Catagorize()}");
        Console.WriteLine($" Trong {Trong.Catagorize()}");
        Console.WriteLine($" Trongle {Trongle.Catagorize()}");
    }
    if (p1)
    {
        Console.WriteLine("WE SHALL BE USING TRONG TO GIVE THAT MOFO A COLOR BOIII");
        Console.WriteLine("TRONG CURRENT HAS NO COLOR SO SET IT BOI");
        Console.WriteLine("ENTER 0 FOR SETTING IT TO BLUE ENTER 1 TO MAKE IT THE SAME COLOR AS Tring");
        int selctor2 = int.Parse(Console.ReadLine());

        if (selctor2 == 0) { Trong.SetColor("blue"); }
        if (selctor2 == 1) { Trong.SetColor(Tring.GetColor()); }
    }
    if (p2)
    {
        Console.WriteLine("WE SHALL NOW BE MESSING WITH THE EDGES OF Trongle and Tring");
        Console.WriteLine("WE SHAL MULTIPLY TRONGLE EDGES BY HOW EVER THE F YOU WANT");
        double X = double.Parse(Console.ReadLine());
        Trongle.MultEdgeByX(X);

        Console.WriteLine("NOW ADD X TO TRING GO ON");
        X = double.Parse(Console.ReadLine());
        Tring.IncEdgeByX(X);

        Console.WriteLine("NOW TRONG SHALL HAVE HIS EDGE INCRESED BY 1");
        Trong.IncEdge();
    }
    if (p3)
    {
        Console.WriteLine("NOW BOI WE SHAL SEE THE PARAMETER AND AREA OF THIS DAMNED TRIANGLES");
        Console.WriteLine("also we shal see if tring and tringle are equal");
        Console.WriteLine($"Trong Area {Trong.Area()}");
        Console.WriteLine($"Trong Parameter {Trong.Parameter()}");
        Console.WriteLine($"Tring Area {Tring.Area()}");
        Console.WriteLine($"Tring Parameter {Tring.Parameter()}");
        if (Tring.Equals(Tringle))
        {
            Console.WriteLine("ThEY ARE EQUAL OMG :SKULL:");
        }
        else
        {
        Console.WriteLine("THEy AINT EQUAL WOWOWOOWOW");
        }


    }
}
void Circles()
{
    Circle c1 = new Circle();
    Circle c2 = new Circle(3.3);
    Circle c3 = new Circle(2.2, "red");
    Circle c4 = new Circle("Purple");


    bool p0 = false;
    if (p0 = true)
    {
        Console.WriteLine(c1);
        Console.WriteLine(c1.ToString());
        double r = -1;
        while (!c1.SetRadius(r))// same as false == c1.SetRadius(r)
        {
            Console.WriteLine("please enter a radius ");
            r = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(c1);

        Console.ReadKey();
    }
    bool p1 = false;
    if (p1)
    {
        Console.WriteLine("Circle 3");
        Console.WriteLine($"circle 3 current size is now {c3}");
        Console.WriteLine("Enter a size to multiply your radius by that size");
        double size = double.Parse(Console.ReadLine());
        c3.MultRadBySize(size);
        Console.WriteLine($"circle 3 size is now {c3}");
        c3.SetColor("white");


        Console.WriteLine("Circle 2");
        Console.WriteLine($"circle 2 current size is now {c2}");
        Console.WriteLine("Enter a size to multiply your radius by that size");
        size = double.Parse(Console.ReadLine());
        c2.IncRadBySize(size);
        Console.WriteLine($"circle 2 size is now {c2}");
        c2.SetColor(c3.GetColor());
    }
    bool p2 = false;
    if (p2)
    {
        if (c2.Equals(c3))
        {
            Console.WriteLine("C2 is equal to C3");
        }
        else
        {
            Console.WriteLine("C2 isnt equal to C3");
        }
    }
}