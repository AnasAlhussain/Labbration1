using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class InMemoryDatabase
    {
        public List <Person> Personer = new List <Person> ();
        public List<Kurs> Kurser = new List<Kurs>();
        public List<Schema> Schemar = new List<Schema>();
        public List<SchemaRad> SchemaRader = new List<SchemaRad>();
        public List<Lärare> Lärarer = new List<Lärare>();
        public List<Student> Studenter = new List<Student>();
        public List<KursTillfälle> KursTillfäller = new List<KursTillfälle>();
        public List<Lokal> Lokaler = new List<Lokal>();
        public List<Utibildning> Utibildninger = new List<Utibildning>();

        


        public void Spara()
        {

            #region Lärare
            Lärare lärare = new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123");


            #endregion



        }
        //  method that returns a list of teachers
        public List<Lärare> HämtaLärare()
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
        public  List<Student> HämtaStudenter()
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
        public List<Kurs> HämtaKurser()
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
        public List<Utibildning> HämtaUtbildningar()
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
        public List<KursTillfälle> HämtaKursTillfällen()
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
        public List<Schema> HämtaSchemar()
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
        public List<SchemaRad> HämtaSchemaRader()
        {
            List<SchemaRad> SchemaRader = new List<SchemaRad>()
            {
                new SchemaRad(new DateTime(2021,09,01), new DateTime(2021,12,01), "09:00-12:00"),
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
        public List<Lokal> HämtaLokaler()
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



    }
}
