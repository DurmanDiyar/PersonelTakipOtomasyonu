using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyon
{
    public class Mesailer
    {

        public int MesaiID { get; set; }
        public int KullaniciID { get; set; }
        public int PersonelID { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }
        public decimal MesaiSaatUcreti { get; set; }
        public decimal Tutar { get; set; }
        public string Donem { get; set; }
        public string OdenmeDurumu { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }



    }
}
