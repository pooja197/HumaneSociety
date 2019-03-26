using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumaneSocietyPets.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; } 
    }

    public class AnimalDBContext:
        ApplicationDbContext
    {
        public DbSet<Animal> Animals
        {
            get;set;
        }
    }
}