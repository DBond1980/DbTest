using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest.DataModels
{
    public class Card
    {
        public int CardId { get; set; }

        public string Manufacturer { get ; set; }
        public string Type { get; set; }
        public int Standard { get; set; }
        public string Comment { get; set; }
        public string RatedPrimaryVoltage { get; set; }
        public float RatedFrequency { get; set; }
        public float RatedVoltageFactor { get; set; }
        public int Principle { get; set; }
        public int Insulation { get; set; }
        public int MeasWind { get; set; }
        public bool ResidWind { get; set; }
        public bool TapWind { get; set; }
        public int TestingProgram { get; set; }
        public float WarningZone { get; set; }
        public string TestVoltages { get; set; }

        //Заложено на будущее развитие программы
        public string CardCode { get; set; } //Код карты (возможно как barcode)
        public float Limit { get; set; } //Ограничение максимального напряжения
                                         //(для предварительных испытаний на заводе)
        //.............................

        public List<Winding> Windings { get; set; }

        public Card()
        {
            //Значения по умолчанию
            Manufacturer = Type = Comment = "";
            RatedPrimaryVoltage = "10/V3";
            RatedFrequency = 50;
            RatedVoltageFactor = 1.2f;
            MeasWind = 1;
            WarningZone = 80;
            TestVoltages = "80;100;120;190";
        }
    }
}
