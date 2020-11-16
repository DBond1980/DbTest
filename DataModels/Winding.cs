using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest.DataModels
{
    public class Winding
    {
        public int WindingId { get; set; }
        public int OrderInList { get; set; }

        public string Terminals { get; set; }
        public string RatedSecondaryVoltage { get; set; }

        public List<WindDetail> WindDetails { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
