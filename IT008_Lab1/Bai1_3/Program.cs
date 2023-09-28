using System;
using System.Diagnostics;
public class GeneticClass<T>
{
    public int n = 0;
    public T[] data = new T[1000];
    public GeneticClass(T[] a, int t)
    {
        n = t;
        data = a;
    }
    public GeneticClass()
    {
    }
    public void add(T t)
    {
        data[n] = t;
        n++;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n, k;
        string[] str = new string[1000];
        Console.Write("Moi ban chon loai (1_int, 2_string, 3_float): ");
        k = int.Parse(Console.ReadLine());
        Console.Write("Moi ban chon so luong: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }
        if (k == 1)
        {
            var a = new GeneticClass<int>();
            for (int i = 0; i < n; i++)
            {
                int f = int.Parse(str[i]);
                a.add(f);
            }
            int t = a.data[0];
            for (int i = 0; i < n; i++)
                if (t < a.data[i])
                    t = a.data[i];
            Console.WriteLine("Vay so lon nhat la: " + t);
        }
        else if (k == 2)
        {
            var a = new GeneticClass<string>();
            for (int i = 0; i < n; i++)
            {
                a.add(str[i]);
            }
            string t = a.data[0];
            for (int i = 1; i < n; i++)
                if (t.Length < a.data[i].Length)
                    t = a.data[i];
            Console.WriteLine("Vay chuoi dai nhat la: " + t);
        }
        else
        {
            var a = new GeneticClass<float>();
            for (int i = 0; i < n; i++)
            {
                float f = float.Parse(str[i]);
                a.add(f);
            }
            float t = a.data[0];
            for (int i = 1; i < n; i++)
                if (t < a.data[i])
                    t = a.data[i];
            Console.WriteLine("Vay so lon nhat la: " + t);
        }
    }
}