using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtraketthucmon
{
    class Cho : DongVat
    {
        public Cho()
        {
        }
        public Cho(string mauLong) : base(mauLong)
        {
            this.MauLong = mauLong;
        }
        public override string keu()
        {
            return base.keu() + "Gau Gau";
        }
    }
}
