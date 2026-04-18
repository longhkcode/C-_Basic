// See https://aka.ms/new-console-template for more information
int choice;
do
{
    Console.WriteLine("Chon phuong an : ");
    Console.WriteLine("1 : Chu Vi HCN");
    Console.WriteLine("2 : Chu Vi Hinh Tron");
    Console.WriteLine("3 : Dien tich HCN");
    Console.WriteLine("4 : Dien tich Hinh Tron");
    Console.WriteLine("5 : Exit ");
    choice =  int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Nhap chieu dai và chieu rong HCN : ");
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi HCN la : " + 2*(length+width));
            break;
        case 2:
            Console.WriteLine("Nhap ban kinh : ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi Hinh tron la : " + 2*radius*Math.PI);
            break;
        case 3:
            Console.WriteLine("Nhap chieu dai và chieu rong HCN : ");
            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Dien Tich HCN la : " + (length*width));
            break;
        case 4:
            Console.WriteLine("Nhap ban kinh : ");
            radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi Hinh tron la : " + (radius*radius*Math.PI));
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Moi ban chon lai phuong an : ");
            choice= int.Parse(Console.ReadLine());
            break;
    }
}while(choice != 5);