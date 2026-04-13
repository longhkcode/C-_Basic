// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan",a);
            }
            else
            {
                Console.WriteLine("{0} la so le",a);
            }
        }
}
