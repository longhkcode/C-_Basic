// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int number = rand.Next(0, 100);
int n = int.Parse(Console.ReadLine());
bool check = false;
do
{
    if (n > number)
    {
        Console.WriteLine("Qua cao : Nhap Lai");
        n = int.Parse(Console.ReadLine());
    }else if (n < number)
    {
        Console.WriteLine("Qua Thap : Nhap Lai");
        n = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Correct");
        check = true;
        break;
    }
}while(true);