using P06BibliotekaPolaczenieZBaza;
using P07AplikacjaZawodnicy.Repositories;
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
    public partial class FrmStartowy : Form
    {
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PodajZawodnikow();
            lbDane.DisplayMember = "DaneRaportowe";                        
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {

        }
    }
}
