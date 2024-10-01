using System.Security.Cryptography.X509Certificates;

namespace Labbration1
{
    internal class Program
    {
        private static InMemoryDatabase Databas = new InMemoryDatabase();
        static void Main(string[] args)
        {
            InMemoryDatabase Database = new InMemoryDatabase();



            Console.WriteLine("Welcome to school system");
            Console.WriteLine("1. Get teacher");
            Console.WriteLine("2. Get student");
            Console.WriteLine("3. Get course");
            Console.WriteLine("4. Get education");
            Console.WriteLine("5. Get room");
            Console.WriteLine("6. Get schedule");

            //Switch case to choose the option
            switch (Console.ReadLine())
            {
                case "1":
                    Databas.HämtaLärare();

                    break;
                case "2":
                   Console.WriteLine( Databas.HämtaStudenter());
                    break;
                case "3":
                    Console.WriteLine(Databas.HämtaKurser());
                    break;
                case "4":
                    Console.WriteLine(Databas.HämtaKursTillfällen());
                    break;
                case "5":
                    Console.WriteLine(Databas.HämtaLokaler());
                    break;
                case "6":
                    Console.WriteLine(Databas.HämtaSchemar());
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

   
}
