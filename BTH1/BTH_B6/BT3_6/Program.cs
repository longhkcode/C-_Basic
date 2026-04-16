// See https://aka.ms/new-console-template for more information

int sum = 0;
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine(sum);