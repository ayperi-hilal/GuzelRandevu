using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class Randevu
    {
        public int musteriNoId { get; set; }
        public Musteri musteri { get; set; }
        public int merkezNoId { get; set; }
        public GuzellikMerkezi merkez { get; set; }

        [DataType(DataType.Date)]
        public DateTime randevuZamani { get; set; }
        public int randevuPuani { get; set; }
    }
}
