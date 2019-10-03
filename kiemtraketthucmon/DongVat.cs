using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtraketthucmon
{
    class DongVat
    {
        public DongVat()
        {
        }
        public DongVat(string mauLong)
        {
            MauLong = mauLong;
        }
        private string mauLong;
        public string MauLong { get => mauLong; set => mauLong = value; }
        public virtual string keu()
        {
            return "";
        }
    }
}
