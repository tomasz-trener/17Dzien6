using P07AplikacjaZawodnicy.Domain;
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
    public partial class FrmSzczegoly : Form
    {
        private Zawodnik zawodnik;
        private FrmStartowy fs;

        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy fs)
        {
            InitializeComponent();
            UzupelnijFormularz(zawodnik);
            this.zawodnik = zawodnik;
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

        private async void btnZapisz_Click(object sender, EventArgs e)
        {
            ZczytytajFormularz();

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(zawodnik);
        }

        private void ZczytytajFormularz()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKrajZawodnika.Text;
            zawodnik.DataUrodzenia = Convert.ToDateTime(txtDaraUr.Text);
            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }
    }
}
