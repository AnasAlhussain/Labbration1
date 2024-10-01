namespace Labbration1
{
    public class Student : Person 
    {
        public string StudentID { get; set; }

        public Student (string StudentID, string förNamn, string efterNamn, string epost)
        {
            this.StudentID = StudentID;
            this.FörNamn = förNamn;
            this.EfterNamn = efterNamn; 
            this.Epost = epost;
        }


    }


}
