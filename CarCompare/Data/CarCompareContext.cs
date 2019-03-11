using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarCompare.Models
{
    public class CarCompareContext : DbContext
    {
        public CarCompareContext (DbContextOptions<CarCompareContext> options)
            : base(options)
        {
        }

        public DbSet<CarCompare.Models.Car> Car { get; set; }
    }
}
