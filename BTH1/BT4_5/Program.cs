// See https://aka.ms/new-console-template for more information

Console.Write("Nhap Tuoi : ");
int n = int.Parse(Console.ReadLine());
if (n >= 18)
{
    Console.WriteLine("Du tuoi");
}
else
{
    Console.WriteLine("Chua du tuoi");
}