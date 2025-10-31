using System.Linq.Expressions;

namespace procviceni_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej kolik jsi měl bodů z testu:");
            int procenta = Convert.ToInt32(Console.ReadLine());

            switch(procenta)
            {
                case int x when (x < 101 && x > 94):
                    Console.WriteLine("1");
                    break;
                case int x when (x < 95 && x > 84):
                    Console.WriteLine("2");
                    break;
                case int x when (x < 85 && x > 69):
                    Console.WriteLine("3");
                    break;
                case int x when (x < 70 && x > 64):
                    Console.WriteLine("4");
                    break;
                case int x when (x < 65 && x > -1):
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("To je blbost");
                    break;
            }
            
            
        }   
    }
}
