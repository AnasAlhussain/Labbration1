namespace Labbration1
{
    public class Lärare : Person
    {
        public string LärareID { get; set; }
        public int TelefonNr { get; set; }
        public string Signatur { get; set; }
        

        public Lärare(string lärareID,string förNamn,string efterNamn,string epost, int telefonNr, string signatur) 
        {
            this.LärareID = lärareID;
            this.FörNamn = förNamn;
            this.EfterNamn = efterNamn;
            this.Epost = epost;
            this.TelefonNr = telefonNr;
            this.Signatur = signatur;
        }

        public void LäggTillSchemaRad()
        {
            Console.WriteLine("Lägg till StartDatum: ");
            
        }


    }
}
