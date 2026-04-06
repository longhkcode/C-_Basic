// See https://aka.ms/new-console-template for more information

public class Program{
    public static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("Nhap vao chieu rong : ");
        width = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao chieu dai : ");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine("Area :  " + width * height);
    }}