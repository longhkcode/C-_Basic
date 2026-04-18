// See https://aka.ms/new-console-template for more information
int a  = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
while (b != 0)
{
    int r = a % b;
    a = b;
    b = r;
}
Console.WriteLine("UCLN la {0}",a);