﻿using Microsoft.EntityFrameworkCore;
namespace L01P022021TH650.Models
{
    public class db_notasContext : DbContext
    {
        public  db_notasContext(DbContextOptions options) : base(options) {

        
        }

        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<alumnos> alumnos { get; set; }



    }
}
