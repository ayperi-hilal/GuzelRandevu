using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuzelRandevu.Models
{
    public class Enumlar
    {
        public enum Cinsiyet
        {
            Erkek, Kadın
        }
        public enum Hizmetler
        {
            SacKesimi,
            SacBakimi,
            SacBoyama,
            Makyaj,
            ManikurPedikur,
            Epilasyon,
            CiltBakimi,
            Masaj,
            Zayiflama
        }
    }
}
