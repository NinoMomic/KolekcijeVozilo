using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijeVozilaXML
{
    class Vozilo
    {
        string model, kategorija;
        int brKotaca;
        long godina;

        public Vozilo(string model, int brKotaca, long godina)
        {
            this.model = model;
            this.brKotaca = brKotaca;
            this.godina = godina;
        }
        public Vozilo() { }

        public string Model { get => model; set => model = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }
        public int BrKotaca { get => brKotaca; set => brKotaca = value; }
        public long Godina { get => godina; set => godina = value; }

        public override string ToString()
        {
            string ispis = "Model: " + Model + "\nKategorija: " + Kategorija + "\nBroj kotaca: " + BrKotaca + "\nGodina: " + Godina + "\n\n";
            return ispis;
        }

    }
    class Motocikl : Vozilo
    {
        public Motocikl(string model, int brKotaca, long godina) : base(model, brKotaca, godina)
        {
            this.Kategorija = "Motocikl";
        }
    }
    class Automobil : Vozilo
    {
        public Automobil(string model, int brKotaca, long godina) : base(model, brKotaca, godina)
        {
            this.Kategorija = "Automobil";
        }

    }
    class Kamion : Vozilo
    {
        public Kamion(string model, int brKotaca, long godina) : base(model, brKotaca, godina)
        {
            this.Kategorija = "Kamion";
        }
    }
}
