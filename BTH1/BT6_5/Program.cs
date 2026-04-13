// See https://aka.ms/new-console-template for more information

Console.Write("Nhap so kwh : ");
float n =  float.Parse(Console.ReadLine());

if (n <= 50)
{
    Console.WriteLine("1500k/kwh");
    Console.WriteLine("So tien dien la : " + n * 1500);
}
else
{
    Console.WriteLine("2000k/kwh");
    Console.WriteLine("So tien dien la : " + (50*1500 + (n-50)*2000));
}