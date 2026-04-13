// See https://aka.ms/new-console-template for more information

Console.Write("Nhap diem cua ban : ");
float n = float.Parse(Console.ReadLine());
if (n >= 8)
{
    Console.WriteLine("Gioi");
}else if (n >= 6.5){
    Console.WriteLine("Kha");
}else if (n >= 5)
{
    Console.WriteLine("TrungBinh");
}else{
    Console.WriteLine("Yeu");
}