﻿using P06BibliotekaPolaczenieZBaza;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PodajZawodnikow();
            lbDane.DisplayMember = "ImieNazwisko";
            

                            
        }
    }
}
