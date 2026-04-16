// See https://aka.ms/new-console-template for more information

using System;

        Console.Write("Nhap 1 so nguyen : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Bảng cửu chương của {n}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

