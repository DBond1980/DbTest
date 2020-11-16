using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest.DataModels
{
    public class WindDetail
    {
        public int WindDetailId { get; set; }
        public int OrderInList { get; set; }

        public string Class { get; set; }
        public float RatedBurden { get; set; }
        public float RatedPowerFactor { get; set; }

        public List<Cycle> Cycles { get; set; }

        public int WindingId { get; set; }
        public Winding Winding { get; set; }

    }
}
