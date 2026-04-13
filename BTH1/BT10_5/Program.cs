// See https://aka.ms/new-console-template for more information

public class Program{
    public static void Main(string[] args){
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
		
        if (a != 0)
        {
            double solution = -b / a;
            Console.Write("The solution is: {0} !", solution);
        }
        else
        {
            if (b == 0)
            {
                Console.Write("The solution is all x!");
            }
            else
            {
                Console.Write("Nod solution!");
            }
        }
        Console.ReadLine();
    }
}