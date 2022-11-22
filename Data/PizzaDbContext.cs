﻿using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace la_mia_pizzeria_static.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizza_db;Integrated Security=True;Encrypt=false;");

        }
    }
}
