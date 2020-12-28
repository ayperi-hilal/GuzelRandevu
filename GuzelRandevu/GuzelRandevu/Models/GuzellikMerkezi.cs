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
        [Display(Name= "Merkez Adı")]
        public string merkezAdi { get; set; }
        [Display(Name = "Merkez Email")]
        public string merkezEmail { get; set; }
        [Display(Name = "Merkez Adresi")]
        public string merkezAdres { get; set; }
        [Display(Name = "Merkez Tel No")]
        public string merkezTelNo { get; set; }
        public string merkezResimUrl { get; set; }
        public List<Randevu> merkezRandevu { get; set; }
    }
}
