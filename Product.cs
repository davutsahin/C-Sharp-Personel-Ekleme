using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Product
    {
        [DisplayName("KULLANICI NO")]
        public int PERSONEL_ID { get; set; }
        [DisplayName("TC NO")]
        public string PERSONEL_TC_NO { get; set; }
        [DisplayName("AD")]
        public string PERSONEL_AD { get; set; }
        [DisplayName("SOYAD")]
        public string PERSONEL_SOYAD { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
       public DateTime PERSONEL_DOGUM_TARIH { get; set; }
        [DisplayName("CİNSİYET")]
        public string PERSONEL_CINSIYET { get; set; }
        [DisplayName("UYRUK")]
        public string PERSONEL_UYRUK { get; set; }
        [DisplayName("TELEFON NO")]
        public string PERSONEL_TELEFON { get; set; }
        [DisplayName("GÖREV")]
        public string PERSONEL_GOREV { get; set; }
        [DisplayName("E-MAİL")]
        public string PERSONEL_EMAIL { get; set; }
        [DisplayName("DURUM")]
        public string PERSONEL_DURUM { get; set; }





    }
}
