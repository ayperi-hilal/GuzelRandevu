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
        public enum randevuTipi 
        {
            [Display(Name = "Saç Boyama")]
            sacBoyama,
            [Display(Name = "Saç Bakımı")]
            sacBakimi,
            [Display(Name = "Saç Kesimi")]
            sacKesimi,
            [Display(Name = "Fön")]
            fon,
            [Display(Name = "Cilt Bakımı")]
            ciltBakimi,
            [Display(Name = "Makyaj")]
            makyaj,
            [Display(Name = "Masaj")]
            masaj,
            [Display(Name = "Manikür Pedikür")]
            manikurPedikur,
            [Display(Name = "Epilasyon")]
            epilasyon,
            [Display(Name = "Zayıflama")]
            zayıflama
        }
        public randevuTipi randevuTuru { get; set; }
    }
}
