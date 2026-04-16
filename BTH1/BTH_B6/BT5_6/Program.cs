// See https://aka.ms/new-console-template for more information

int tich = 1;
int n =int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    tich *= i;
}
Console.WriteLine("{0}! = {1}",n,tich);