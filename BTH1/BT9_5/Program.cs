// See https://aka.ms/new-console-template for more information
Console.WriteLine("MENU");
Console.WriteLine("Moi Ban chon : \n1:Xem thông tin\n2:Cài đặt\n3:Thoát\n");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("Xem Thong Tin");
        break;
    case 2:
        Console.WriteLine("Cai Dat");
        break;
    case  3:
        Console.WriteLine("Thoat");
        break;
    default:
        Console.WriteLine("Error");
        break;
}