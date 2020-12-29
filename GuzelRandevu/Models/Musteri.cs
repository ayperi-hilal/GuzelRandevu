using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class Musteri:IdentityUser
    {
        [Display(Name = "Ad")]
        public string musteriAdi { get; set; }
        [Display(Name = "Soyad")]
        public string musteriSoyadi { get; set; }
        [Display(Name = "Tel No")]
        public int musteriTelNo { get; set; }
        [Display(Name = "Cinsiyet")]
        public Enumlar.Cinsiyet cinsiyet { get;set;}
        public ICollection<Randevu> randevular { get; set; }

    }
}
