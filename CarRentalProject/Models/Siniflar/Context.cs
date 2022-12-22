using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarRentalProject.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Subeler> Subelers { get; set; }
        public DbSet<Hakkimizda> Hakkiimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }        
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}