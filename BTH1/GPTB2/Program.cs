
class Program
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        if (a == 0) return;
        
        double delta = b * b - 4 * a * c;
        
        if (delta < 0) {
            Console.WriteLine("PT vo nghiem");
        }else if (delta == 0) {
            double x = -b / (2 * a);
            Console.WriteLine("PT co nghiem kep x = " + x);
        }else {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}