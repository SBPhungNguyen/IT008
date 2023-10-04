using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PhanSo
{
    double tu;
    double mau;
    //khoi tao phan so
    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }
    //khoi tao phan so co thamso truyen vao
    public PhanSo(int t, int m)
    {
        tu = t;
        mau = m;
    }
    //nhap phan so
    public void Nhap()
    {
        double t, m;
        Console.WriteLine("\nNhap Tu Phan So: ");
        t = Double.Parse(Console.ReadLine());

        Console.WriteLine("\nNhap Mau Phan So: ");
        m = Double.Parse(Console.ReadLine());
        while (m == 0)
        {
            Console.WriteLine("\nMau khong the bang 0, vui long nhap lai.");
            m = Console.Read();
        }
        tu = t;
        mau = m;
    }
    //xuat phanso
    public void Xuat()
    {
        Console.WriteLine(tu + "/" + mau);
    }
    //Cac Toan Tu +, -, *, /
    //cong hai phan so

    public static PhanSo operator +(PhanSo p1, PhanSo p2)
    {
        PhanSo KQ = new PhanSo();
        KQ.tu = p1.tu * p2.mau + p2.tu * p1.mau;
        KQ.mau = p1.mau * p2.mau;
        return KQ;
    }
    //tru hai phan so
    public static PhanSo operator -(PhanSo p1, PhanSo p2)
    {
        PhanSo KQ = new PhanSo();
        KQ.tu = p1.tu * p2.mau - p2.tu * p1.mau;
        KQ.mau = p1.mau * p2.mau;
        return KQ;
    }
    //nhan hai phan so
    public static PhanSo operator *(PhanSo p1, PhanSo p2)
    {
        PhanSo KQ = new PhanSo();
        KQ.tu = p1.tu * p2.tu;
        KQ.mau = p1.mau * p2.mau;
        return KQ;
    }
    //chia hai phan so
    public static PhanSo operator /(PhanSo p1, PhanSo p2)
    {
        PhanSo KQ = new PhanSo();
        KQ.tu = p1.tu * p2.mau;
        KQ.mau = p1.mau * p2.tu;
        return KQ;
    }
    //Cac Toan Tu ==, !=, <, >,
    //Equals
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    //==
    public static bool operator ==(PhanSo p1, PhanSo p2)
    {
        if (p1.tu * p2.mau == p2.tu * p1.mau)
            return true;
        return false;
    }
    //!=
    public static bool operator !=(PhanSo p1, PhanSo p2)
    {
        if (p1.tu * p2.mau != p2.tu * p1.mau)
            return true;
        return false;
    }
    //Equals 
    public override bool Equals(object obj)
    {
        if (!(obj is PhanSo)) return false;
        return this == (PhanSo)obj;
    }
    //>
    public static bool operator >(PhanSo p1, PhanSo p2)
    {
        if (p1.tu / p1.mau > p2.tu / p2.mau)
            return true;
        return false;
    }
    //<
    public static bool operator <(PhanSo p1, PhanSo p2)
    {
        if (p1.tu / p1.mau < p2.tu / p2.mau)
            return true;
        return false;
    }
}

namespace sum
{
    class Program
    {
        static void Main()
        {
            PhanSo A = new PhanSo();
            PhanSo B = new PhanSo();
            Console.WriteLine("Phan So A ");
            A.Nhap();
            Console.WriteLine("\nPhan So B: ");
            B.Nhap();

            Console.WriteLine("\nPhan So A: "); A.Xuat();
            Console.WriteLine("\nPhan So B: "); B.Xuat();

            PhanSo C = A + B;
            Console.WriteLine("\nA + B = "); C.Xuat();
            PhanSo D = A - B;
            Console.WriteLine("\nA - B = "); D.Xuat();
            PhanSo E = A * B;
            Console.WriteLine("\nA * B = "); E.Xuat();
            PhanSo F = A / B;
            Console.WriteLine("\nA / B = "); F.Xuat();

            Console.Write("\nSo Sanh A va B: \n");
            if (A == B)
                Console.WriteLine("A = B");
            else
            {
                Console.WriteLine("A != B");
                if (A > B)
                    Console.WriteLine("A > B");
                else
                    Console.WriteLine("A < B");
            }
        }
    }
}
