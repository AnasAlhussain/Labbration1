using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    public class Schema
    {
        public string SchemaNamn { get; set; }
        public List<SchemaRad> SchemaRads { get; set; }

        public List<Kurs> Kurs { get; set; }
        public Utibildning Utibildning { get; set; }

        public List<Person> Person { get; set; }
    }
}
