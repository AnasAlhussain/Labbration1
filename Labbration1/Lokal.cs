using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class Lokal
    {
        public string LokalNummer { get; set; }
        public int Plaster { get; set; }

        public Lokal(string lokNum, int natalplats)
        {
            this.LokalNummer = lokNum;
            this.Plaster = natalplats;
        }
    }
}
