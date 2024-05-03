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

            // sayi yapilarinda matematiksel islemler:
            rakam = 10;
            rakam = rakam + 2; // rakami 2 arttirdik
            rakam += 2; // 2 daha arttirdik (ust satir ile ayni isi yapar)

            rakam += 1; // rakami 1 arttirdik
            rakam++; // 1 arttirdik;

            //rakam su anda 16
            MessageBox.Show((rakam++).ToString()); // ekrana 16 yazar ama hemen ardindan 17 yapar
            MessageBox.Show(rakam.ToString());

            // Dizi ve Kolleksiyon yapilari
            string[] isimlerDizisi = new string[3];
            isimlerDizisi[0] = "Zeynep";
            isimlerDizisi[1] = "Ozan";
            isimlerDizisi[2] = "Emre";
            string ikinciIsim = isimlerDizisi[1]; //ikinci elemani aldik
            string sonuncuIsim = isimlerDizisi[isimlerDizisi.Length - 1]; // sonuncu elemani aldik: -1 sayma sayisinin 1den baslamasindan kaynakli

            int[] sayilar = new int[] { 5, 10, 22, 55 };

            // List
            List<string> meyveler = new List<string>();
            int listeninUzunlugu = meyveler.Count; // su an 0
            meyveler.Add("elma");
            meyveler.Add("portakal");
            meyveler.AddRange(new List<string>(){ "armut", "karpuz" });
            listeninUzunlugu = meyveler.Count; // su an 4
            // listenin en basina eklemek istiyorum: (elma, portakal, armut, karpuz)
            meyveler.Insert(1, "erik"); //(elma, erik, portakal, amut, karpuz)
            int portakalinIndexi = meyveler.IndexOf("portakal"); //2
            int mandalinaIndexi = meyveler.IndexOf("mandalina"); // -1
            string ucuncuMeyve = meyveler[2];



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

            // Donguler
            int girilenRakam = 18;
            // bu rakami eger 10dan buyuk ise 10a kadar kucultmek istiyorum
            while (girilenRakam > 10)
            {
                //girilenRakam -= 2;
                girilenRakam--;
            }

            rakam = 8;
            do
            {
                girilenRakam--;
            } while (girilenRakam < 10);

            Random rastgele = new Random();
            // burada do-while EN AZ bir kere calisir
            do
            {
                rakam = rastgele.Next();
            } while (rakam > 10);
            rakam = rastgele.Next(0, 100);// 0 dahil 100 haric rastgele sayi belirler

            // isim dizisindeki tum isimleri onyuzdeki listbox a yazdirdik
            for (int indexIsim = 0; indexIsim < isimlerDizisi.Length; indexIsim++)
            {
                IsimListBox.Items.Add(isimlerDizisi[indexIsim]); 
            }

            // yukaridakinin aynisi ama daha gelismisi:
            foreach (string herbirIsim in isimlerDizisi)
            {
                IsimListBox.Items.Add(herbirIsim);
            }

            // yuzden 0a kadar olan 3un kati sayilari cikariyoruz
            List<int> ucunKatlariAzalan = new List<int>();
            for (int number = 99; number > 0; number-= 3)
            {
                ucunKatlariAzalan.Add(number);
            }

            // meyveler listesinde ilk portakalin indexini arayalim
            meyveler = new List<string>() { "elma", "armut", "portakal", "kiraz", "portakal", "karpuz" };
            int orange = -1;
            for (int indexMeyve = 0; indexMeyve < meyveler.Count; indexMeyve++)
            {
                if (meyveler[indexMeyve] == "portakal")
                {
                    orange = indexMeyve;
                    break;
                }
            }

            // String operasyonlari
            // escape character: \
            string mesaj = "Ben bugun \"Ulus Metal\" de egitim verdim";
            mesaj = "\tSayin yetkili, \r\n\tDilekcemin isleme konmasini rica ederim. \r\nSaygilar";
            string dosyaAdresi = "C:\\Users\\FrozenDragon\\source\\repos\\UlusMetalDers1\\bin\\Debug\\net6.0-windows";
            // @ escape characteri iptal eder
            dosyaAdresi = @"C:\Users\FrozenDragon\source\repos\UlusMetalDers1\bin\Debug\net6.0-windows";

            // string birlestirmek:
            string isim = "Emre";
            string soyisim = "Tekinsoy";
            string magaza = "Vatan Computer";
            decimal fiyat = 123.66m;
            int telefonNo = 6630;
            int taksitSayisi = 6;

            // en basit yontem: bunu lutfen kullanmiyoruz.
            string sms = "Sayin " + isim + " " + soyisim + ", " + magaza + " dan yapmis oldugunuz" + fiyat + "Lira harcamanizi, " + telefonNo + " taksit yazarak " + taksitSayisi + "taksit yapabilrisiniz.";
            // perrformansi daha iyidir ama yorucudur
            sms = string.Concat("Sayin ", isim, " ", soyisim, ", ", magaza, " dan yapmis oldugunuz ", fiyat, "Lira harcamanizi, ", telefonNo, " taksit yazarak ", taksitSayisi, "taksit yapabilrisiniz.");
            // performansi iyidir, kullanimi da eh fena degildir
            sms = string.Format("Sayin {0} {1},{2} magazasindan yapmis oldugunuz {3} Lira harcamanizi, {4} taksit yazarak {5} taksitlendirebilirsiniz.", isim, soyisim, magaza, fiyat, telefonNo, taksitSayisi);
            // >c# 6.0: Interpolation : iste budur:
            sms = $"Sayin {isim} {soyisim}, {magaza} magazasindan yapmis oldugunuz {fiyat} Lira harcamanizi, {telefonNo} taksit yazarak {taksitSayisi} taksitlendirebilirsiniz.";

            // Eger string cok satirda oluasacak ise:
            StringBuilder stringBuilder = new StringBuilder("Sayin ");
            stringBuilder.Append(isim);
            stringBuilder.Append($" {soyisim}");
            stringBuilder.Append($", {magaza} magazasindan yapmis oldugunuz {fiyat} Lira harcamanizi, {telefonNo} taksit yazarak {taksitSayisi} taksitlendirebilirsiniz.");
            sms = stringBuilder.ToString();

            StringBuilder meyveBuilder = new StringBuilder("Benim stogumdaki meyveler: ");
            foreach (string meyve in meyveler)
            {
                meyveBuilder.Append($", {meyve}");
            }
            string meyveRaporu = meyveBuilder.ToString();

            // Fonksiyon ve parametreler
            rakam = BirSayiUret();
            rakam = SayilariTopla(12, 23, 34, 45);
            string ifade = IsimListesiOlustur("Katilimcilarimiz:", "Ahmet", "MEhmet", "Ayse");
            string hitap = HitapOlustur("Ali", "Aydin","Prof.Dr.");
            hitap = HitapOlustur("Zeynep", "Yildirim", selam:"Iyiaksamlar");
            hitap = HitapOlustur("Ahmet", "Aydin");

            int a = 15;
            SayiyiYaz0(a);
            MessageBox.Show(a.ToString());

            a = 15;
            SayiyiYaz1(ref a);
            MessageBox.Show(a.ToString());

            a = 15;
            SayiyiYaz2(out a);
            MessageBox.Show(a.ToString());

            //rakam = Convert.ToInt32(TxtBox1.Text);
            if (int.TryParse(TxtBox1.Text, out a))
            {
                rakam = a;
            }
        }

        void SayiyiYaz0(int sayi)
        {
            sayi += 10;
            MessageBox.Show(sayi.ToString());
        }

        void SayiyiYaz1(ref int sayi)
        {
            sayi += 10;
            MessageBox.Show(sayi.ToString());
        }
        void SayiyiYaz2(out int sayi)
        {
            sayi = 15;
            sayi += 10;
            MessageBox.Show(sayi.ToString());
        }


        // geri donusu olmayan metodlar:
        void Temizle()
        {
            TxtBox1.Clear();
        }
        Random  rastgele = new Random();

        /// <summary>
        /// Bu metod rastgele 0 ile 100 arasi sayi uretir
        /// </summary>
        /// <returns>int</returns>
        int BirSayiUret()
        {
            return rastgele.Next(0, 100);
        }

        /// <summary>
        /// Rastgele verilen sayilar arasinda sayi uretir
        /// </summary>
        /// <param name="altlimit">AltLimit (dahil)</param>
        /// <param name="ustlimit">Ust Limit (haric)</param>
        /// <returns>int</returns>
        int BirSayiUret(int altlimit, int ustlimit)
        {
            if (altlimit > ustlimit)
            {
                return rastgele.Next(ustlimit, altlimit);
            }
            return rastgele.Next(altlimit, ustlimit);
        }

        int SayilariTopla(int s1, int s2)
        {
            return s1 + s2;
        }

        int SayilariTopla(params int[] sayilar)
        {
            int toplam = 0;
            for (int indexSayi = 0; indexSayi < sayilar.Length; indexSayi++)
            {
                toplam += sayilar[indexSayi];
            }
            return toplam;
        }

        int SayilariTopla(List<int> sayilar)
        {
            int toplam = 0;
            for (int indexSayi = 0; indexSayi < sayilar.Count; indexSayi++)
            {
                toplam += sayilar[indexSayi];
            }
            return toplam;
        }

        string IsimListesiOlustur(string cumle, params string[] isimler)
        {
            StringBuilder stringBuilder = new StringBuilder(cumle);
            foreach (string isim in isimler)
            {
                stringBuilder.Append($", ");
            }
            return stringBuilder.ToString();
        }
        string HitapOlustur( string isim, string soyisim, string unvan = "Sayin", string selam = "Merhaba")
        {
            //if (string.IsNullOrEmpty(unvan))
            //{
            //    unvan = "Sayin";
            //}
            return $"{unvan} {isim} {soyisim}, {selam}";
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
