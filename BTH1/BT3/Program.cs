public class Program
{
    public static void Main()
    {
        Console.WriteLine("Nhap chieu dai va Rong của HCN1 : ");
        double length1 = double.Parse(Console.ReadLine());
        double width1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhapp chieu dai va chieu rong cuar HCN2 :  ");
        double length2 = double.Parse(Console.ReadLine());
        double width2 = double.Parse(Console.ReadLine());
        
        double s1 = length1 * width1;
        double s2 = length2 * width2;
        
        double cv1 = (length1 + width1) * 2;
        double cv2 = (length2 + width2) * 2;
        
        Console.WriteLine("HCN1 : " + "\n" + "DienTich = " + s1 + "m2\n" + "ChuVi = " + cv1 + "m");
        Console.WriteLine("HCN2 : " + "\n" + "DienTich = " + s2 + "m2\n" + "ChuVi = " + cv2 + "m");

        if (s2 > s1)
        {
            Console.WriteLine("Hinh chu nhat 2 co dien tich lon hon.");
        }
        else
        {
            Console.WriteLine("Hinh chu nhat 1 co dien tich lon hon.");
        }
    }
}