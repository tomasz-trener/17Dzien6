using P06BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik= pzb.WyslijPolecenieSQL("select id_zawodnika, imie,nazwisko from zawodnicy");

            lbDane.Items.Clear();

            foreach (var w in wynik)
                lbDane.Items.Add(w[0] + " " + w[1]);


                            
        }
    }
}
