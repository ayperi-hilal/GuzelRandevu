using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class GuzellikMerkezi
    {
        [Key]
        public int merkezId { get; set; }
        [Display(Name= "Adı")]
        public string merkezAdi { get; set; }
        [Display(Name = "Email Adresi")]
        public string merkezEmail { get; set; }
        [Display(Name = "Adresi")]
        public string merkezAdres { get; set; }
        [Display(Name = "Tel No")]
        public string merkezTelNo { get; set; }
        public string merkezResimUrl { get; set; }
        [Display(Name = "Hizmetler")]
        public Enumlar.Hizmetler hizmetler { get; set; }
        public ICollection<Randevu> randevular { get; set; }
    }
}
