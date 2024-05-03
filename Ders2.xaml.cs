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
    /// Interaction logic for Ders2.xaml
    /// </summary>
    public partial class Ders2 : Window
    {
        public Ders2()
        {
            InitializeComponent();

            Telefon yeniTel = new Telefon();
            yeniTel.Marka = "Xiaomi";
            yeniTel.Calis();
            //yeniTel.Sebeke = "Turkcell";
            yeniTel.G4 = true;

            Telefon ikinciTel = new Telefon("Samsung");
            ikinciTel.Calis();
        }
    }
}
