using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectTravelTrip.Models.Siniflar
{
    public class Restoran
    {
        [Key]
        public int ID { get; set; }
        public string RestoranAdi { get; set; }
        public string RestoranImage { get; set; }
        public string RestoranAciklama { get; set; }
     

    }
}