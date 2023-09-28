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
    public int max(int[] t)
    {
        int m = t[0];
        for (int i = 1; i < n; i++)
        {
            if (m < t[i])
                m = t[i];
        }
        return m;
    }
    public float max(float[] t)
    {
        float m = t[0];
        for (int i = 1; i < n; i++)
        {
            if (m < t[i])
                m = t[i];
        }
        return m;
    }
    public string max(string[] t)
    {
        string m = t[0];
        for (int i = 1; i < n; i++)
        {
            if (m.Length < t[i].Length)
                m = t[i];
        }
        return m;
    }
    public void xuat(T t)
    {
        Console.WriteLine("Vay phan tu lon nhat la: " + t);
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
        if (k < 1 || k > 3)
        {
            throw new Exception("Nhap sai loai du lieu");
        }
        Console.Write("Moi ban chon so luong: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Moi nhap phan tu thu " + i + ": ");
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
            int t = a.max(a.data);
            a.xuat(t);
        }
        else if (k == 2)
        {
            var a = new GeneticClass<string>();
            for (int i = 0; i < n; i++)
            {
                a.add(str[i]);
            }
            string t = a.max(a.data);
            a.xuat(t);
        }
        else if (k == 3)
        {
            var a = new GeneticClass<float>();
            for (int i = 0; i < n; i++)
            {
                float f = float.Parse(str[i]);
                a.add(f);
            }
            float t = a.max(a.data);
            a.xuat(t);
        }
    }
}