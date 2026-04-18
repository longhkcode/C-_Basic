// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int i = 2; 
while (n > 1)
{
    if (n % i == 0)
    {
        Console.Write(i);
        n /= i;
        if (n>1) Console.Write(" x ");
    } else
    {
        i++;
    }
}