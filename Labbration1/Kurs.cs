using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class Kurs
    {
        public string KursNamn { get; set; }
        public string Kurskod { get; set; }
        public string ExaminatiosTillfälle { get; set; }
        public string Akronym { get; set; }
        public double HögskolaPoäng { get; set; }

        public Schema Schema { get; set; }

        public List<KursTillfälle> KursTillfälles { get; set; }
        public Utibildning Utibildning { get; set; }


        public Kurs(string kursnamn,string kurskod,string exam,string akronym,double poäng)
        {
            this.KursNamn = kursnamn;
            this.Kurskod = kurskod;
            this.ExaminatiosTillfälle = exam;
            this.Akronym = akronym;
            this.HögskolaPoäng = poäng;
        }


    }
}
