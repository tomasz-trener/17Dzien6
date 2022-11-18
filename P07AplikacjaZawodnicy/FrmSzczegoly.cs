using P07AplikacjaZawodnicy.Domain;
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
    public partial class FrmSzczegoly : Form
    {
        private FrmStartowy fs;

        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy fs)
        {
            InitializeComponent();
            UzupelnijFormularz(zawodnik);
            this.fs = fs;
        }

        public void UzupelnijFormularz(Zawodnik zawodnik)
        {
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKrajZawodnika.Text = zawodnik.Kraj;
            txtDaraUr.Text = zawodnik.DataSformatowana;
            txtWzrost.Text = zawodnik.Wzrost.ToString();
            txtWaga.Text = zawodnik.Waga.ToString();
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.frmSzczegoly = null;
        }
    }
}
