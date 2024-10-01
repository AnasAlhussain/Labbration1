namespace Labbration1
{
    public class Lärare : Person
    {
        public string LärareID { get; set; }
        public int TelefonNr { get; set; }
        public string Signatur { get; set; }


       

        public Lärare(string lärareID, string förNamn, string efterNamn, string epost, int telefonNr, string signatur)
        {
            this.LärareID = lärareID;
            this.FörNamn = förNamn;
            this.EfterNamn = efterNamn;
            this.Epost = epost;
            this.TelefonNr = telefonNr;
            this.Signatur = signatur;
        }

       
      

        public static Lärare LogIn(List<Lärare> lärare)
        {

            string enterName = "";
            while (true) //While-loop that runs as long as the login attempts are not 0.
            {
                Console.Clear();
                Console.Write("\nUsername: ");
                enterName = Console.ReadLine().ToUpper();
                Console.Write("Pincode: ");
                string enteredPincode = Console.ReadLine();
                if (enteredPincode != null)
                {
                    //Using the FirstOrDeafult and Lambda expression it searches through the list of admins and looks for a matching username and pincode, Return the the admin as loggedInAdmin.

                    Lärare loggedInAdmin = lärare.FirstOrDefault(a => a.LärareID == enterName && a.FörNamn == enteredPincode);

                    if (loggedInAdmin != null) //If loggedInAdmin has returned a value
                    {
                        Console.Clear();
                        Console.WriteLine($"\nLog in successful, Welcome {loggedInAdmin.FörNamn.ToUpper()}!" +
                            $"\nPlease wait while the information is retrieved...");
                        Thread.Sleep(2000);
                        return loggedInAdmin; //Returns the loggedInAdmin

                    }
                    else //If the user enters the wrong credentials
                    {
                        Console.WriteLine($"\nWrong Credentials \nPress enter to continue");
                        Console.ReadLine();
                    }
                }
                else //IF the admin writes something else then numbers
                {

                    Console.WriteLine($"\nUnsuccessful login. The pincode can only contain numbers.\nPress enter to continue");
                    Console.ReadLine();
                }
                return null;
            }
        }
    }
}