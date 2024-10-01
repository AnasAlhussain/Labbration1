using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class SchemaRad
    {
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }
        public string Moment { get; set; }
        public Kurs Kurs { get; set; }
        public Lokal Lokal { get; set; }




        public SchemaRad(DateTime startDatum, DateTime slutDatum, string moment) 
        {
            this.StartDatum = startDatum;
            this.SlutDatum = slutDatum;
            this.Moment = moment;
            
        }

    }
        
}
