﻿using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Data
{
    public class MovieContext : DbContext //db context özelliklerini alır
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {

        }
        public DbSet <Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Crew> Crews{ get; set; }
        public DbSet<Cast> Casts { get; set; }


        ////protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=movies.db");
        //}
    }
}
