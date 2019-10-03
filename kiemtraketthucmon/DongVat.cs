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

        public string tiengkeu
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

        public string MauLong
        {
            get { return MauLong; }
            set { MauLong = value; }
        }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gau Gau"))
                MessageBox.Show("Cho Keu " + this.tiengkeu);
            else if (tiengkeu.Equals("Meo Meo"))
                MessageBox.Show("Meo Keu " + this.tiengkeu);
        }
    }
}
