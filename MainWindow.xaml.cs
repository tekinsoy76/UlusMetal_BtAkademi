using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UlusMetalDers1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Guid uniqueidentifier = Guid.NewGuid();

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(TxtBox1.Text);
            MessageBox.Show(uniqueidentifier.ToString());
            Calisma();
        }

        void Calisma()
        {
            // C# da degiskenler
            // Isimlendirme
            // - Rakam ile baslanamaz
            // - _ haricinde hicbir nokatalama isareti kullanilamaz (bosluk dahil)
            // - Iki nesne yada yapi ayni ismi alamaz
            // - Ingilizce alfabesindeki harfleri kullanin

            string yazi = "Bu benim ilk yazi tipim";
            char karakter = '@';

            bool varmiYokmu = true;

            int varsayilanTamSayi = 2434; // -20000000 - 20000000
            short kucukTamSayi = 32000; // -32000 - 32000
            byte enKucukTamSayi = 255; // 0 - 255
            long enBuyukTamSayi = -73547;

            uint pozitifTamSayi = 40000000; // 0 - 40000000
            ushort pozitifKucukTamSayi = 64000; // 0 - 64000
            ulong pozitifBuyukTamSayi = 764547642354675236;
            sbyte enKucukNegatifDeOlabilen = -128; // -128 - 128

            double varsayilanOnadalik = 432432.53543d; //burdaki d suffix double icin opsiyonel; yazilmasa da olur
            decimal buyukOndalik = 35435.56465m;
            float kucukOndalik = 453242.5354f;

            DateTime simdi = DateTime.Now;
            DateTime egitimBaslangici = new DateTime(2024, 5, 2, 9, 30, 0);

            Guid guid = Guid.NewGuid(); // Ornek: 550e8400-e29b-41d4-a716-446655440000
            Guid bosGuid = Guid.Empty; // 00000000-0000-0000-0000-000000000000

            object nesne = varsayilanTamSayi;
            var sayi = varmiYokmu; // var kelimesi bir degisken degildir; esitligin oteki tarafina gore c# kendisi belirler

            // tur donusumleri
            string ornek = string.Empty;
            decimal ondalik = Convert.ToDecimal(varsayilanOnadalik);
            int rakam = kucukTamSayi; // eger %100 hata verme olasiligi YOK ise; implicit conversion gerceklesir.
            rakam = Convert.ToInt32(enBuyukTamSayi);
            string yaziIle = "1234";
            rakam = int.Parse(yaziIle);
            yaziIle = Convert.ToString(enBuyukTamSayi);
            yaziIle = enBuyukTamSayi.ToString();

            // Casting
            // casting bir convert islemi degildir; kimlik bildirmektir
            object s = 1234;
            rakam = (int)s;

            // Kosul ifadeler (if, switch)
            rakam = 355;
            if (rakam < 10)
            {
                MessageBox.Show("Teke basamakli rakam");
            }
            else if (rakam < 100 && rakam >= 10)
            {
                MessageBox.Show("Cift basamakli rakam");
            }
            else
            {
                MessageBox.Show("Cok basamakli rakam");
            }

            switch (rakam)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    MessageBox.Show("tek basamakli rakam");
                    break;
                default:
                    MessageBox.Show("cok basamakli rakam");
                    break;
            }

            bool dolmusgeldimi = true;
            bool otobusgeldimi = true;
            bool akbilimvarmi = false;

            if (dolmusgeldimi || (otobusgeldimi && akbilimvarmi))
            {
                // arac bin kodlari
            }

            if (bakiyeYeterlimi() & kayitAlindimi())
            {
                // islem yapildi
            }

            rakam = 4;
            if (rakam == 0)
            {
                yaziIle = "sifir";
            }
            else if (rakam == 1)
            {
                yaziIle = "bir";
            }
            else if (rakam == 2)
            {
                yaziIle = "iki";
            }
            else if (rakam == 3)
            {
                yaziIle = "uc";
            }
            else if (rakam == 4)
            {
                yaziIle = "dort";
            }
            else
            {
                yaziIle = "unknown";
            }

            switch (rakam)
            {
                case 0:
                    yaziIle = "sifir";
                    break;
                case 1:
                    yaziIle = "bir";
                    break;
                case 2:
                    yaziIle = "iki";
                    break;
                case 3:
                    yaziIle = "uc";
                    break;
                case 4:
                    yaziIle = "dort";
                    break;
                default:
                    yaziIle = "unknown";
                    break;
            }

            paraTransferi transfer = paraTransferi.swift;
            switch (transfer)
            {
                case paraTransferi.virman:
                    break;
                case paraTransferi.havale:
                    break;
                case paraTransferi.eft:
                    break;
                case paraTransferi.swift:
                    break;
                case paraTransferi.arbitraj:
                    break;
                default:
                    break;
            }
        }

        bool bakiyeYeterlimi()
        {
            return false;
        }

        bool kayitAlindimi()
        {
            //loglama
            return true;
        }
    }



    // burasi class disinda, namespace icerisinde
    enum paraTransferi
    {
        virman,
        havale,
        eft,
        swift,
        arbitraj
    }
}
