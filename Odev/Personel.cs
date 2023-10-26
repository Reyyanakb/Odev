using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.Yas = gYas;
            this.mesai = gMesai;
            this.Unvan = gUnvan;
        }
        string Ad;
        public string ad
        {
            get => Ad;
            set => Ad = value;

        }
        string Adres;
        public string adres
        {
            get => Adres;
            set => Adres = value;

        }

        int Yas;
        public int yas
        {
            get => Yas;
            set => Yas = value;

         }
        string Unvan;
        public string unvan
        {
            get => Unvan;
            set => Unvan = value;
        }
        int Mesai;
        public int mesai
        {
            get { return mesai; }
            set => Mesai = value;
        }
        public int ucretHesapla()
        {
            return this.mesai * 100;
        }
        public void ucretHesapla(int ekUcret)//değer dönmeyecekse void kullanırsın
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }





    }
}
