// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap vao chieu cao : ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap vao can nang : ");
        double weight = Convert.ToDouble(Console.ReadLine());
        
        double bmi = weight / Math.Pow(height,2);
        bmi = Math.Round(bmi, 1);
        
        Console.WriteLine("BMI : " + bmi);
        if (bmi < 18.5)
        {
            Console.Write("Underweight");
        }else if ( bmi < 25){
            Console.Write("Normal");
        }else if (bmi < 30)
        {
            Console.Write("Overweight");
        }
        else
        {
            Console.Write("Obese");
        }
    }
}