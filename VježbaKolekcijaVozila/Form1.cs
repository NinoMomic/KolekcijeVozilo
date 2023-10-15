using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XML_kolekcije
{
    public partial class Form1 : Form
    {
        List<Vozilo> vozila = new List<Vozilo>();
        Motocikl motor;
        Automobil auto;
        Kamion kamion;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtGod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtGod.Text, "[^0-9]"))
                {
                    txtGod.Text = txtGod.Text.Remove(txtGod.Text.Length - 1);
                    MessageBox.Show("Molim upisite samo brojeve.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (FormatException ex) { }
        }

        private void txtKotac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtKotac.Text, "[^0-9]"))
                {
                    txtKotac.Text = txtKotac.Text.Remove(txtKotac.Text.Length - 1);
                    MessageBox.Show("Molim upisite samo brojeve.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (Convert.ToInt32(txtKotac.Text) % 2 != 0)
                {
                    txtKotac.Text = null;
                    MessageBox.Show("Molim upisite parni broj.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException ex) { }
        }

        private void txtIspisClicked(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKotac.Text) == 2)
            {
                this.motor = new Motocikl(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
            }
            else if (Convert.ToInt32(txtKotac.Text) == 4)
            {
                this.auto = new Automobil(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
            }
            else if (Convert.ToInt32(txtKotac.Text) > 4)
            {
                this.kamion = new Kamion(txtModel.Text, Convert.ToInt32(txtKotac.Text), Convert.ToInt64(txtGod.Text));
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKotac.Text) == 2)
            {
                vozila.Add(motor);
            }
            else if (Convert.ToInt32(txtKotac.Text) == 4)
            {
                vozila.Add(auto);
            }
            else if (Convert.ToInt32(txtKotac.Text) > 4)
            {
                vozila.Add(kamion);
            }

            txtModel.Clear();
            txtGod.Clear();
            txtKotac.Clear();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach (var vozilo in vozila)
            {
                txtIspis.AppendText(vozilo.ToString());
            }
        }
    }
}
