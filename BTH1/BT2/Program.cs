public class Program
{
    public static void Main()
    {
        Console.WriteLine("Nhap so tien USD: ");
        decimal usd = decimal.Parse(Console.ReadLine());

        Console.WriteLine("So tien USD: " + usd);

        decimal vnd = usd * 25300;
        Console.WriteLine("So tien VND: " + vnd);

        decimal phi = (decimal)(0.5 / 100) * vnd;
        Console.WriteLine("Phi chuyen khoan: " + phi);

        decimal tong = phi + vnd;
        Console.WriteLine("Tong tien phai tra: " + tong);
    }
} 