using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UlusMetalDers1
{
    /// <summary>
    /// Interaction logic for UlusEmlak.xaml
    /// </summary>
    public partial class UlusEmlak : Window
    {
        public UlusEmlak()
        {
            InitializeComponent();

            // Daire class
            // Property:
            //  Kat - int
            //  No - int
            //  Metrekare - double
            //  Oda Sayisi - int

            // ODEV: Daire class'ina Fiyat diye bir property eklicez
            // Her dairenin fiyati: (metrekare x 1000) + (kat x 1000) + (oda x 10000)
            // Bu fiyatlari da listede gostericez.

            DaireleriDoldur();
            DaireAciklamalariniOlustur();
            ListBoxDaire.ItemsSource = daireAciklamalari;
        }
        
        private List<Daire> apartman = new List<Daire>();
        private List<string> daireAciklamalari = new List<string>();

        private void DaireleriDoldur()
        {
            // Apartmanimiz 30 katli
            // Ilk 10 katta 4, Sonraki 10 katta 2, En ust 10 katta 1'er daire
            // Ilk 10 kattaki (1-10) daireler: 1+1, 60 metrekare
            // Ikinci 10 kat (11-20) daireler: 3+1, 120 merekare
            // Ucuncu 10 kat (21-30) daireler: 5+1, 230 metrekare
            int kapiNo = 1;
            
            for (int kat = 1; kat <= 10; kat++)
            {
                for (int kapi = 1; kapi <= 4; kapi++)
                {
                    Daire daire = new Daire()
                    {
                        Kat = kat,
                        No = kapiNo,
                        Metrekare = 60,
                        OdaSayisi = 1
                    };
                    apartman.Add(daire);
                    kapiNo++;
                }
            }
            for (int kat = 11; kat <= 20; kat++)
            {
                for (int kapi = 1; kapi <= 2; kapi++)
                {
                    Daire daire = new Daire()
                    {
                        Kat = kat,
                        No = kapiNo,
                        Metrekare = 120,
                        OdaSayisi = 3
                    };
                    apartman.Add(daire);
                    kapiNo++;
                }
            }
            for (int kat = 21; kat <= 30; kat++)
            {
                Daire daire = new Daire()
                {
                    Kat = kat,
                    No = kapiNo,
                    Metrekare = 230,
                    OdaSayisi = 5
                };
                apartman.Add(daire);
                kapiNo++;
            }
        }

        private void DaireAciklamalariniOlustur()
        {
            foreach (Daire herBirDaire in apartman)
            {
                daireAciklamalari.Add($"NO: {herBirDaire.No}, Kat: {herBirDaire.Kat}, {herBirDaire.OdaSayisi}+1, {herBirDaire.Metrekare}m2");
            }
        }
    }
}
