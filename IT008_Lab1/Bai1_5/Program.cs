using System;
using System.IO;

class Placeholder
{
    public static void Main()
    {
        Console.WriteLine("Nhap duong dan thu muc muon khao sat: ");
        string path = Console.ReadLine();
        DirectoryInfo di = new DirectoryInfo(path);
        while (!(di.Exists))
        {
            Console.WriteLine("Duong dan thu muc khong ton tai, vui long nhap lai: ");
            path = Console.ReadLine();
            di = new DirectoryInfo(path);
        }

        FileInfo[] files = new FileInfo[1000];
        files = di.GetFiles();
        int counter = files.Length;
        string filename;

        Console.WriteLine("\nDuong dan thu muc: " + path);
        Console.WriteLine("So File trong thu muc: " + counter);
        Console.WriteLine("\nTen cac file co trong thu muc: ");

        for (int i = 0; i < counter; i++)
        {
            filename = files[i].Name;
            Console.WriteLine(filename);
        }
    }
}
