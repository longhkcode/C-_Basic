// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main()
    {
        const float usd = 23000;
        Console.WriteLine("Nhap vao so USD bn co : ");
        int myUSD = int.Parse(Console.ReadLine());
        Console.WriteLine("So VND : " +  myUSD * usd);
    }
}