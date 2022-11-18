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
                //for (int j = 0; j < w.Length; j++)
                //    if (w[j] == DBNull.Value)
                //        w[j] = null;

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)w[0];

                if (w[1] != DBNull.Value)
                    z.Id_trenera = (int)w[1]; // null w c# różni się od null w bazie danych

                z.Imie = (string)w[2];
                z.Nazwisko = (string)w[3];
                z.Kraj = (string)w[4];

                if (w[5] != DBNull.Value)
                    z.DataUrodzenia = (DateTime)w[5];
               // if (w[6] != DBNull.Value)
                    z.Wzrost = (int)w[6];
                if (w[7] != DBNull.Value)
                    z.Waga = (int)w[7];
                zawodnicy[i] = z;
            }
            return zawodnicy;
        }

        public void Edytuj(Zawodnik z)
        {



        }
    }
}
