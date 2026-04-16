// See https://aka.ms/new-console-template for more information

Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());

int a = 1, b = 1;

Console.Write(a + " " + b + " ");

for (int i = 3; i <= n; i++)
{
    int c = a + b;
    Console.Write(c + " ");
    a = b;
    b = c;
}