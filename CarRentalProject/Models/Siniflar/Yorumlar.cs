using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalProject.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public Subeler Sube { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    } 
}