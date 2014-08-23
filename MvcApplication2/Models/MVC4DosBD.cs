using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    //la sgte linea es una herencia
    public class MVC4DosBD : DbContext
    {
       //instanciamos nuestra Base de Datos

        public MVC4DosBD() : base("name = Default Connection") {
        
        }

        public DbSet <Restaurant> Restaurants { get; set; }

        public DbSet<RestaurantReview> Reviwes { get; set; }
    }
}