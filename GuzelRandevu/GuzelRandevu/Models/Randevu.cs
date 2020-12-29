using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class Randevu
    {
        public string musteriNoId { get; set; } //PK
        public Musteri musteri { get; set; }
        public int merkezNoId { get; set; } //PK
        public GuzellikMerkezi merkez { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Randevu Günü")]
        public DateTime randevuGunu { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Randevu Saati")]
        public DateTime randevuSaati { get; set; }
        [Display(Name = "Randevu Puanı")]

        public int randevuPuani { get; set; }
    }
}
