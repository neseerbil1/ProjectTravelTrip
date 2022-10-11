using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectTravelTrip.Models.Siniflar
{
    public class Otel
    {
        [Key]
        public int ID { get; set; } 
        public string OtelAdi { get; set; } 
        public string OtelImage { get; set; } 
        public string OtelAciklama { get; set; } 


       
    }
}