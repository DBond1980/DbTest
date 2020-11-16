using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest.DataModels
{
    public class Cycle
    {
        public int CycleId { get; set; }
        public int OrderInList { get; set; }

        public float Burden1 { get; set; }
        public float Burden2 { get; set; }
        public float Burden3 { get; set; }
        public string Voltages { get; set; }


        public int WindDetailId { get; set; }
        public WindDetail WindDetail { get; set; }
    }

}
