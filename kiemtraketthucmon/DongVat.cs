using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiemtraketthucmon
{
    class DongVat
    {
        private string Keu;

        public string keu
        {
            get { return Keu; }
            set { Keu = value; }
        }

        public DongVat(string stKeu)
        {
            this.Keu = stKeu;
        }

        public DongVat()
        {
        }

        private string MauLong;

        public string MauLongdv
        {
            get
            { return MauLong; }
            set
            { MauLong = value; }
        }



        public virtual void Talk()
        {
            if (keu.Equals("Gau gau") && (MauLongdv.Equals("den")))
                MessageBox.Show( this.keu + "Toi la cho long mau: " + this.MauLongdv);
            else if (keu.Equals("Meo meo") && (MauLongdv.Equals("vang")))
                MessageBox.Show( this.keu + "Toi la meo long mau:" + this.MauLongdv);
        }
    }
}
