// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        double diemToan = double.Parse(Console.ReadLine());
        double diemLy = double.Parse(Console.ReadLine());
        double diemHoa = double.Parse(Console.ReadLine());

        double DTB = (diemToan + diemLy + diemHoa) / 3;
        DTB = Math.Round(DTB, 2);
        Console.WriteLine(DTB);
        if (DTB >= 8) {
            Console.WriteLine("Gioi");
        }else if (DTB >= 6.5)
        {
            Console.WriteLine("kha");
        }else if (DTB >= 5)
        {
            Console.WriteLine("TrungBinh");
        }
        else
        {
            Console.WriteLine("Yeu");
        }
    }
}