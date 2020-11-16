using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DbTest.Databases;
using DbTest.DataModels;

namespace DbTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestCardsDbContext _cardsDb;
        public List<Card> Cards;

        public MainWindow()
        {
            InitializeComponent();
            ReadCards();

            _cardsDb = new TestCardsDbContext();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _cardsDb.Cards.AddRange(Cards);
            _cardsDb.SaveChanges();
        }

        private void ReadCards()
        {
            Card c = new Card
            {
                Manufacturer = "Test",
                Type = "TAPJ 110/220",
                Comment = "No Comment",
                RatedPrimaryVoltage = "110/V3",
                Windings = new List<Winding>
                {
                    new Winding
                    {
                        Terminals = "a1-n1", RatedSecondaryVoltage = "100",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,2", RatedBurden = 10, RatedPowerFactor = 0.8f,
                                Cycles = new List<Cycle>
                                {
                                    new Cycle {Burden1 = 10, Burden2 = 2.5f, Burden3 = 10, Voltages = "80;100;120"},
                                    new Cycle {Burden1 = 2.5f, Burden2 = 0, Burden3 = 0, Voltages = "80;100;120"}
                                }
                            },
                            new WindDetail
                            {
                                Class = "0,5", RatedBurden = 20, RatedPowerFactor = 0.8f,
                                Cycles = new List<Cycle>
                                {
                                    new Cycle {Burden1 = 10, Burden2 = 2.5f, Burden3 = 10, Voltages = "80;100;120"},
                                    new Cycle {Burden1 = 2.5f, Burden2 = 0, Burden3 = 0, Voltages = "80;100;120"}
                                }
                            }
                        }
                    },
                    new Winding
                    {
                        Terminals = "a2-n2", RatedSecondaryVoltage = "100/V3",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,5", RatedBurden = 20, RatedPowerFactor = 0.8f,
                                Cycles = new List<Cycle>
                                {
                                    new Cycle {Burden1 = 10, Burden2 = 2.5f, Burden3 = 10, Voltages = "80;100;120"},
                                    new Cycle {Burden1 = 2.5f, Burden2 = 0, Burden3 = 0, Voltages = "80;100;120"}
                                }
                            }
                        }
                    },
                }
            };
            Card c2 = new Card
            {
                Manufacturer = "Test2",
                Type = "TAPJ 110/220",
                Comment = "No Comment",
                RatedPrimaryVoltage = "110/V3",
                Windings = new List<Winding>
                {
                    new Winding
                    {
                        Terminals = "a1-n1", RatedSecondaryVoltage = "100",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,2", RatedBurden = 10, RatedPowerFactor = 0.8f,
                                Cycles = new List<Cycle>
                                {
                                    new Cycle {Burden1 = 10, Burden2 = 2.5f, Burden3 = 10, Voltages = "80;100;120"},
                                    new Cycle {Burden1 = 2.5f, Burden2 = 0, Burden3 = 0, Voltages = "80;100;120"}
                                }
                            },
                            new WindDetail
                            {
                                Class = "0,5", RatedBurden = 20, RatedPowerFactor = 0.8f,
                                Cycles = new List<Cycle>
                                {
                                    new Cycle {Burden1 = 10, Burden2 = 2.5f, Burden3 = 10, Voltages = "80;100;120"},
                                    new Cycle {Burden1 = 2.5f, Burden2 = 0, Burden3 = 0, Voltages = "80;100;120"}
                                }
                            }
                        }
                    },
                    new Winding
                    {
                        Terminals = "a2-n2", RatedSecondaryVoltage = "100/V3",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,2", RatedBurden = 10, RatedPowerFactor = 0.8f
                            }
                        }
                    },
                }
            };

            Card c3 = new Card
            {
                Manufacturer = "Test2",
                Type = "TAPJ 110/220",
                Comment = "No Comment",
                RatedPrimaryVoltage = "110/V3",
                Windings = new List<Winding>
                {
                    new Winding
                    {
                        Terminals = "a1-n1", RatedSecondaryVoltage = "100",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,2", RatedBurden = 10, RatedPowerFactor = 0.8f
                            },
                            new WindDetail
                            {
                                Class = "0,5", RatedBurden = 20, RatedPowerFactor = 0.8f
                            }
                        }
                    },
                    new Winding
                    {
                        Terminals = "a2-n2", RatedSecondaryVoltage = "100/V3",
                        WindDetails = new List<WindDetail>
                        {
                            new WindDetail
                            {
                                Class = "0,2", RatedBurden = 10, RatedPowerFactor = 0.8f
                            }
                        }
                    },
                }
            };

            for (int i = 0; i < 100; i++)
            {
                c3.Windings[1].WindDetails.Add(
                    new WindDetail
                    {
                        Class = "0,2",
                        RatedBurden = i,
                        RatedPowerFactor = 0.8f
                    });
            }

            Cards = new List<Card>
            {
                c,
                c2,
                c3,
                new Card {Manufacturer = "OLTEST", Type = "TAPJ 110/220", Comment = "No Comment", RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "ABB", Type = "TAPJ 110/220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Emiter", Type = "DFSD0", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Uman", Type = "YUYT220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "OLTEST", Type = "TAPJ 110/220", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "ABB", Type = "TAPJ 110/220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Emiter", Type = "DFSD0", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Uman", Type = "YUYT220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "OLTEST", Type = "TAPJ 110/220", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "ABB", Type = "TAPJ 110/220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Emiter", Type = "DFSD0", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Uman", Type = "YUYT220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "OLTEST", Type = "TAPJ 110/220", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "ABB", Type = "TAPJ 110/220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Emiter", Type = "DFSD0", Comment = "No Comment", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
                new Card {Manufacturer = "Uman", Type = "YUYT220", MeasWind = 1, RatedPrimaryVoltage = "110/V3"},
            };

        }
    }
}
