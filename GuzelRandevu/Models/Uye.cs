using GuzelRandevu.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class Uye:IdentityUser
    {
        [Display(Name ="Adınız")]
        public string uyeAdi { get; set; }
        [Display(Name = "Soyadınız")]
        public string uyeSoyadi { get; set; }
        [Display(Name = "Telefon Numaranız")]
        [DataType(DataType.PhoneNumber)]
        public string musteriTelNo { get; set; }
        public ICollection<Randevu> randevular { get; set; }

    }
}
