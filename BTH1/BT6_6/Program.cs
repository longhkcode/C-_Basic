// See https://aka.ms/new-console-template for more information

Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());

double S = 0;

for (int i = 1; i <= n; i++)
{
    S += 1.0 / i;
}

Console.WriteLine("Tổng S = " + S);
