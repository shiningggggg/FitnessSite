using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Model
{
    public class AppModelEntities:DbContext
    {
        public AppModelEntities() : base("FitnessConnection")
        { }
        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<Article> Article { get; set; }
    }
}
