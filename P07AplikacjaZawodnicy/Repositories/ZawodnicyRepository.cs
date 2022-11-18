using P06BibliotekaPolaczenieZBaza;
using P07AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07AplikacjaZawodnicy.Repositories
{
    internal class ZawodnicyRepository
    {
        public Zawodnik[] PodajZawodnikow()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik = 
                pzb.WyslijPolecenieSQL(
        "select id_zawodnika, id_trenera, imie, nazwisko,kraj,data_ur,wzrost,waga from zawodnicy");

            // teraz należy przprowadzić transformacje wyniku na tablice Zaowdnikow 

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                var w = wynik[i];
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)w[0];
                z.Id_trenera = (int)w[1];
                z.Imie = (string)w[2];
                z.Nazwisko = (string)w[3];
                z.Kraj = (string)w[4];
                z.DataUrodzenia = (DateTime)w[5];
                z.Wzrost = (int)w[6];
                z.Waga = (int)w[7];
                zawodnicy[i] = z;
            }
            return zawodnicy;
        }
    }
}
