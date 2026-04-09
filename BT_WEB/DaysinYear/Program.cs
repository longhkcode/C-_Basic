// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 2:
                Console.WriteLine("The month '2' has 28 or 29 days!");
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10: 
            case 12:
                Console.WriteLine("The month {0} has 31 days",month);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("The month {0} has 30 days",month);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}