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
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public int musteriTelNo { get; set; }
        public List<Randevu> musteriRandevular { get; set; }

    }
}
