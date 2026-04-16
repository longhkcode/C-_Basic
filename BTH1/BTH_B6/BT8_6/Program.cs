// See https://aka.ms/new-console-template for more information

Console.Write("Nhập số dòng m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Nhập số cột n: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= m; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}