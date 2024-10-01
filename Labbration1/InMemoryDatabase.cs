using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class InMemoryDatabase
    {
        public List <Person> Personer { get; set; }
        public List<Kurs> Kurser { get; set; }
        public List<Schema> Schemar { get; set; }
        public List<SchemaRad> SchemaRader { get; set; }
        public List<Lärare> Lärarer { get; set; }
        public List<Student> Studenter { get; set; }
        public List<KursTillfälle> KursTillfäller { get; set; }
        public List<Lokal> Lokaler { get; set; }
        public List<Utibildning> Utibildninger  { get; set; }




    public void Spara()
        {

            #region Lärare
            Lärare lärare = new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123");


            #endregion



        }
        //  method that returns a list of teachers
        public static List<Lärare> HämtaLärare()
        {
            List<Lärare> Lärarer = new List<Lärare>()
            {
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),

            };
            foreach (var lärare in Lärarer)
            {
                Console.WriteLine("ID :{0}  , Name : {1} {2} , E-amil: {3}, Phone: {4}, signatur: {5}",
                    lärare.LärareID,lärare.FörNamn,lärare.EfterNamn,lärare.Epost,lärare.TelefonNr,lärare.Signatur);
            }

            return Lärarer;
        }

        //  method that returns a list of students
        public static List<Student> HämtaStudenter()
        {
            List<Student> Studenter = new List<Student>()
            {
                new Student("101","Osama","hussain","osama@bhs.se" ),
                new Student("102","Osama","hussain","osama@bhs.se" ),
                new Student("103","Osama","hussain","osama@bhs.se" ),
                new Student("104","Osama","hussain","osama@bhs.se" ),
            };
            foreach (var student in Studenter)
            {
                Console.WriteLine("ID :{0}  , Name : {1} {2} , E-amil: {3}",
                    student.StudentID, student.FörNamn, student.EfterNamn, student.Epost);
            }
            return Studenter;
        }

        //  method that returns a list of courses
        public static List<Kurs> HämtaKurser()
        {
            List<Kurs> Kurser = new List<Kurs>()
            {
                new Kurs("C#","C#","2021-09-01","C#",5.5),
                new Kurs("C#","C#","2021-09-01","C#",5.3),
                new Kurs("C#","C#","2021-09-01","C#",5.7),
                new Kurs("C#","C#","2021-09-01","C#",4.3),
            };
            foreach (var kurs in Kurser)
            {
                Console.WriteLine("KursNamn :{0}  , Akronym : {1} , Kod: {2}, Examination: {3}, Poäng: {4}",
                    kurs.KursNamn, kurs.Akronym, kurs.Kurskod, kurs.ExaminatiosTillfälle, kurs.HögskolaPoäng);
            }
            return Kurser;
        }

        //  method that returns a list of courses
        public static List<Utibildning> HämtaUtbildningar()
        {
            List<Utibildning> Utibildninger = new List<Utibildning>()
            {
                new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
            };

            foreach (var utibildning in Utibildninger)
            {
                Console.WriteLine("UtbildningsNamn :{0}  , Akronym : {1} , Kurser: {2}",
                    utibildning.UtbildningsNamn, utibildning.Akronym, utibildning.Kurser);
            }
            return Utibildninger;
        }

        //  method that returns a list of courses
        public static List<KursTillfälle> HämtaKursTillfällen()
        {
            List<KursTillfälle> KursTillfäller = new List<KursTillfälle>()
            {
                new KursTillfälle(){StartDatum = new DateTime(2021,09,01), SlutDatum = new DateTime(2021,12,01)},
                new KursTillfälle(){StartDatum = new DateTime(2021,09,01), SlutDatum = new DateTime(2021,12,01)},
                new KursTillfälle(){StartDatum = new DateTime(2021,09,01), SlutDatum = new DateTime(2021,12,01)},
                new KursTillfälle(){StartDatum = new DateTime(2021,09,01), SlutDatum = new DateTime(2021,12,01)},
            };
            foreach (var kursTillfälle in KursTillfäller)
            {
                Console.WriteLine("StartDatum :{0}  , SlutDatum : {1}",
                    kursTillfälle.StartDatum, kursTillfälle.SlutDatum);
            }

                return KursTillfäller;

        }



        //  method that returns a list of courses
        public static List<Schema> HämtaSchemar()
        {
            List<Schema> Schemar = new List<Schema>()
            {
                new Schema(){SchemaNamn = "Schema1", SchemaRads = HämtaSchemaRader() },
                new Schema(){SchemaNamn = "Schema2", SchemaRads = HämtaSchemaRader() },
                new Schema(){SchemaNamn = "Schema3", SchemaRads = HämtaSchemaRader() },
                new Schema(){SchemaNamn = "Schema4", SchemaRads = HämtaSchemaRader() },
            };

            foreach (var schema in Schemar)
            {
                Console.WriteLine("SchemaNamn :{0}  , SchemaRads : {1}",
                    schema.SchemaNamn, schema.SchemaRads);
            }
            return Schemar;
        }


        //  method that returns a list ofSchemaRader
        public static List<SchemaRad> HämtaSchemaRader()
        {
            List<SchemaRad> SchemaRader = new List<SchemaRad>()
            {
                new SchemaRad(new DateTime(2021,09,01),  new DateTime(2021,12,01), "09:00-12:00"),
                new SchemaRad(new DateTime(2021,09,01), new DateTime(2021,12,01), "09:00-12:00"),
                new SchemaRad(new DateTime(2021,09,01), new DateTime(2021,12,01), "09:00-12:00"),
                new SchemaRad(new DateTime(2021,09,01), new DateTime(2021,12,01), "09:00-12:00"),
            };

            foreach (var schemaRad in SchemaRader)
            {
                Console.WriteLine("StartDatum :{0}  , SlutDatum : {1}, Tid: {2}",
                    schemaRad.StartDatum, schemaRad.SlutDatum, schemaRad.Moment);
            }
            return SchemaRader;
        }

        //  method that returns a list of lokaler
        public static List<Lokal> HämtaLokaler()
        {
            List<Lokal> Lokaler = new List<Lokal>()
            {
                new Lokal( "A123", 30),
                new Lokal( "A123", 30),
                new Lokal( "A123", 30),
                new Lokal( "A123", 30),
            };

            foreach (var lokal in Lokaler)
            {
                Console.WriteLine("LokalNamn :{0}  , AntalPlatser : {1}",
                    lokal.LokalNummer, lokal.Plaster);
            }
            return Lokaler;
        }


        public static void StartApp()
        {
            List<Lärare> Teachers = InMemoryDatabase.HämtaLärare();

            
           
                Console.BackgroundColor = ConsoleColor.Blue; //These lines control the color theme of the program.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                WelcomeMenu();
                Console.WriteLine("\nAre you a Lärare or Admin?" +
                    "\n\n[1] Student" +
                    "\n[2] Lärare"); // IN the starting menu the user can choose to log in as admin or a regular customer.


                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Welcome Lärare");
                        break;
                    case "2":
                        Lärare logginLärare = Lärare.LogIn(Teachers);
                        AdminMenu();
                        break;
                }
            

        }

        private static void WelcomeMenu()
        {
            Console.Beep();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n         Welcome to School System" +
            "\n         ----------------------------" +
            "\n                 _ _.-'`-._ _\r\n                ;.'________'.;\r\n     _________n.[____________].n_________\r\n    |\"\"_\"\"_\"\"_\"\"||==||==||==||\"\"_\"\"_\"\"_\"\"]\r\n    |\"\"\"\"\"\"\"\"\"\"\"||..||..||..||\"\"\"\"\"\"\"\"\"\"\"|\r\n    |LI LI LI LI||LI||LI||LI||LI LI LI LI|\r\n    |.. .. .. ..||..||..||..||.. .. .. ..|\r\n    |LI LI LI LI||LI||LI||LI||LI LI LI LI|\r\n ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,,\r\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
            DailyMessage();
            Console.WriteLine("\nPress Enter to Log in!");
            Console.ReadKey();
        }

        private static void DailyMessage()
        {
            Random random = new Random();
            List<string> messages = new List<string>
            {
                "\nThe only System you need in your life!",
                "\nExpertise you need. Service you deserve!",
                "\nWe Built This System For You!",
                "\nYour First Choice!",
                "\nWe know Adminstartion!",
                "\nSystem for people with better things to do!",
                "\nBecause life’s complicated enough!",
                "\nMake Dreams Happen!",
                "\nYour First Choice!",
                "\nSystem Focused on You!"
            };
            string randomMessage = messages[random.Next(messages.Count)];
            Console.WriteLine(randomMessage);
        }

        public static void AdminMenu()
        {
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
                    HämtaLärare();

                    break;
                case "2":
                    HämtaStudenter();
                    break;
                case "3":
                    HämtaKurser();
                    break;
                case "4":
                    HämtaKursTillfällen();
                    break;
                case "5":
                    HämtaLokaler();
                    break;
                case "6":
                    HämtaSchemar();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
