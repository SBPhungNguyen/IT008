using System;

public abstract class Shape
{
    protected string ten;
    public abstract double Area();
    public abstract void Draw();
    public abstract void Input();
}

public class Rectangle : Shape
{
    protected new string ten = "Hinh chu nhat";
    protected double a;
    protected double b;
    public override double Area()
    {
        double result = a * b;
        return result;
    }
    public override void Draw()
    {
        Console.WriteLine("Ten hinh: {0} \n", ten);
        Console.WriteLine("Chieu dai: {0} \n", a);
        Console.WriteLine("Chieu rong: {0} \n", b);
        Console.WriteLine("Dien tich: {0} \n", Area());
    }
    public override void Input()
    {
        Console.WriteLine("Nhap thong tin hinh chu nhat:\n");
        Console.WriteLine("Nhap chieu dai: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong: ");
        b = Convert.ToInt32(Console.ReadLine());
    }
}

public class Circle : Shape
{
    protected new string ten = "Hinh tron";
    protected double r;
    public override double Area()
    {
        double result = 3.14 * r * r;
        return result;
    }
    public override void Draw()
    {
        Console.WriteLine("Ten hinh: {0} \n", ten);
        Console.WriteLine("Ban kinh: {0} \n", r);
        Console.WriteLine("Dien tich: {0} \n", Area());
    }
    public override void Input()
    {
        Console.WriteLine("Nhap thong tin hinh tron:\n");
        Console.WriteLine("Nhap ban kinh: ");
        r = Convert.ToInt32(Console.ReadLine());
    }
}

public class Triangle : Shape
{
    protected new string ten = "Hinh tam giac";
    protected double a;
    protected double b;
    protected double c;
    public override double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public override void Draw()
    {
        Console.WriteLine("Ten hinh: {0} \n", ten);
        Console.WriteLine("Canh thu nhat: {0} \n", a);
        Console.WriteLine("Canh thu hai: {0} \n", b);
        Console.WriteLine("Canh thu ba: {0} \n", c);
        Console.WriteLine("Dien tich: {0} \n", Area());
    }
    public override void Input()
    {
        Console.WriteLine("Nhap thong tin hinh tam giac:\n");
        Console.WriteLine("Nhap canh thu nhat: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap canh thu hai: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap canh thu ba: ");
        c = Convert.ToInt32(Console.ReadLine());
    }
}

public class Square : Rectangle
{
    protected new string ten = "Hinh vuong";
    public override double Area()
    {
        double result = a * a;
        return result;
    }
    public override void Draw()
    {
        Console.WriteLine("Ten hinh: {0} \n", ten);
        Console.WriteLine("Canh: {0} \n", a);
        Console.WriteLine("Dien tich: {0} \n", Area());
    }
    public override void Input()
    {
        Console.WriteLine("Nhap thong tin hinh vuong:\n");
        Console.WriteLine("Nhap canh: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
}

class Program
{
    public static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("Ban muon nhap may hinh? ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Random rnd = new Random();
            int random_num = rnd.Next(3);
            if (random_num == 0)
            {
                Rectangle a = new Rectangle();
                a.Input();
                shapes.Add(a);
            }
            else if (random_num == 1)
            {
                Circle a = new Circle();
                a.Input();
                shapes.Add(a);
            }
            else if (random_num == 2)
            {
                Triangle a = new Triangle();
                a.Input();
                shapes.Add(a);
            }
            else
            {
                Square a = new Square();
                a.Input();
                shapes.Add(a);
            }
        }

        Console.WriteLine("Cac hinh ban da nhap:\n");
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
