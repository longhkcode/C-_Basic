// See https://aka.ms/new-console-template for more information

Console.Write("Nhập chiều cao h: ");
int h = int.Parse(Console.ReadLine());

for (int i = 1; i <= h; i++)
{
    // In khoảng trắng
    for (int j = 1; j <= h - i; j++)
    {
        Console.Write(" ");
    }

    // In dấu *
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}