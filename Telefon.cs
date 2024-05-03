using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OS
//      Application Domain
//          Framework
//              App
//                  namespace
//                      class, enum, interface, struct (varsayilan access modifier: internal)
//                      attribute
//                          constructor
//                          field (private)
//                          property (private)
//                          metod (private)

// Access Modifier
//      Public: Butun dunyaya acik
//      Internal: Sadece bulundugumuz uygulamanin icinden ulasilabilir
//      ?
//      Private: 


namespace UlusMetalDers1
{
    public class Telefon
    {
        // Constructor: Bu nesne ayaga kalkarken yapacagimiz islerin yazildigi metod
        public Telefon()
        {

        }
        // Constructor overload:
        public Telefon(string marka)
        {
            Marka = marka;
        }
        // Field:
        public string Marka;

        public string Sebeke { get; set; }


        private bool G4Acik;
        public bool G4
        {
            get { return G4Acik; }
            set 
            {
                if (!string.IsNullOrEmpty(Sebeke))
                {
                    G4Acik = value;
                }
            }
        }


        public void Calis()
        {

        }
    }
}
