// See https://aka.ms/new-console-template for more information
int diem;
do
{
    Console.Write($"Nhap so diem cua ban : ");
    diem = int.Parse(Console.ReadLine());
}while(diem < 0 || diem > 10);
Console.Write(diem);