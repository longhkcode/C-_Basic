// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
String result = "";
while (n > 0)
{
    int k  = n % 10;
    n /= 10;
    result += k.ToString();
}
Console.WriteLine(int.Parse(result));