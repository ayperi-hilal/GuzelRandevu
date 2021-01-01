using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models

{
    public class Randevu
    {
        public string uyeId { get; set; }
        public Uye uye { get; set; }
        public string merkezId { get; set; }
        public GuzellikMerkezi guzellikMerkezi { get; set; }

        [Display(Name = "Değerlendirmeniz")]
        [DataType(DataType.MultilineText)]
        public string randevuDegerlendirmesi { get; set; }
        [Display(Name = "Puanınız")]
        public int randevuPuani { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Randevu Günü ve Saati")]
        public DateTime randevuSaati { get; set; }
        [Display(Name = "Randevu Türü")]
        public randevuTipi randevuTuru { get; set; }
        public enum randevuTipi
    {
        [Display(Name = "Saç Boyama")]
        sacBoyama=0,
        [Display(Name = "Saç Bakımı")]
        sacBakimi=1,
        [Display(Name = "Saç Kesimi")]
        sacKesimi=2,
        [Display(Name = "Fön")]
        fon=3,
        [Display(Name = "Cilt Bakımı")]
        ciltBakimi=4,
        [Display(Name = "Makyaj")]
        makyaj=5,
        [Display(Name = "Masaj")]
        masaj=6,
        [Display(Name = "Manikür Pedikür")]
        manikurPedikur=7,
        [Display(Name = "Epilasyon")]
        epilasyon=8,
        [Display(Name = "Zayıflama")]
        zayıflama=9
    }

        
    }
}
