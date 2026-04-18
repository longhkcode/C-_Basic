// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
int count = 0;
while (n > 0)
{
    count++;
    n /= 10;
}
Console.WriteLine(count);