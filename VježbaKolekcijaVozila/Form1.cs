using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VježbaKolekcijaVozila
{
    public partial class Form1 : Form
    {
        class Vozilo
        {
            int brojKotaca, godinaProizvodnje;
            string model, kategorija;

            public Vozilo(string mode, string kategorija, int brojKotaca, int  godinaProizvodnje) 
            {
                this.BrojKotaca = brojKotaca;
                this.GodinaProizvodnje = godinaProizvodnje;
                this.Model = model;
                this.Kategorija = kategorija;
            }

            public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
            public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
            public string Model { get => model; set => model = value; }
            public string Kategorija { get => kategorija; set => kategorija = value; }
        }
        class Motocikl : Vozilo
        {
            public Motocikl(string model, string kategorija, int brojKotaca, int godinaProizvodnje) : base (model, kategorija, godinaProizvodnje, brojKotaca)
            {
                this.BrojKotaca = 2;
                this.Kategorija = "Motocikl";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            try
            {
                int brojKot = Convert.ToInt32(txtBoxBrojKotaca.Text);
                if(brojKot == 2)
                {
                    Motocikl vozilo = new Motocikl(txtBoxModel.Text, Convert.ToInt32(txtBoxBrojKotaca.Text));
                    TxtBoxIspis.Text = vozilo.Kategorija;
                }
            }
        }
    }
}
