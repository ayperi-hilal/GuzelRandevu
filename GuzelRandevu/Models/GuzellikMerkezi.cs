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
        public string merkezId { get; set; }
        [Display(Name = "Merkez Adı")]
        public string merkezAdi { get; set; }
        [Display(Name = "Merkez Adresi")]
        public string merkezAdresi { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Merkez Emaili")]
        public string merkezEmail { get; set; }
        [DataType(DataType.ImageUrl)]
        public string merkezResim { get; set; }
        public ICollection<Randevu> randevular { get; set; }
    }
}
