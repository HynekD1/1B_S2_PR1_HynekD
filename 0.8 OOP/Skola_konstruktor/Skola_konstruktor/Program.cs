namespace Skola_konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvoření objektu  z třídy Student
            Student s01 = new Student("Pepík", 15);
            Console.WriteLine(s01.Introduction());
            Student s02 = new Student("Jenda", 14);
            Console.WriteLine(s02.Introduction());
            Student s03 = new Student("Tereza", 10);
            Console.WriteLine(s03.Introduction());
        }
    }
}
