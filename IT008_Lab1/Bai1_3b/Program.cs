using System;
using System.Runtime.ExceptionServices;

class GeneticClass<T>
{
    public T[] data = new T[1000];
    public int n = 0;
    public GeneticClass()
    {

    }
    public GeneticClass(T[] data, int t)
    {
        n = t;
        this.data = data;
    }
    public void Add(T t)
    {
        data[n] = t;
        n++;
    }
    public int min(int[] a)
    {
        int t = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] < t)
                t = a[i];
        }
        return t;
    }
    public float min(float[] a)
    {
        float t = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] < t)
                t = a[i];
        }
        return t;
    }
    public string min(string[] a)
    {
        string t = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i].Length < t.Length)
                t = a[i];
        }
        return t;
    }
    public void xuat(T t)
    {
        Console.WriteLine("Thanh phan nho nhat la: " + t);
    }
}
class Program
{
    static void Main(string[] args)
    {
        int k;
        string[] str = new string[1000];
        Console.Write("Moi ban chon loai (1_int, 2_string, 3_float): ");
        k = int.Parse(Console.ReadLine());
        if (k < 1 || k > 3)
        {
            throw new Exception("Nhap sai loai du lieu");
        }
        Console.Write("Moi ban chon so luong: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Moi nhap phan tu thu " + i + ": ");
            str[i] = Console.ReadLine();
        }
        if (k == 1)
        {
            GeneticClass<int> a = new GeneticClass<int>();
            for (int i = 0; i < n; i++)
                a.Add(int.Parse(str[i]));
            a.xuat(a.min(a.data));
        }
        if (k == 2)
        {
            GeneticClass<float> a = new GeneticClass<float>();
            for (int i = 0; i < n; i++)
                a.Add(float.Parse(str[i]));
            a.xuat(a.min(a.data));
        }
        else
        {
            GeneticClass<string> a = new GeneticClass<string>();
            for (int i = 0; i < n; i++)
                a.Add(str[i]);
            a.xuat(a.min(a.data));
        }
    }
}