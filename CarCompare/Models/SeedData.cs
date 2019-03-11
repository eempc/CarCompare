using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarCompare.Models {
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new CarCompareContext(serviceProvider.GetRequiredService<DbContextOptions<CarCompareContext>>())) {
                if (context.Car.Any()) return;

                context.Car.AddRange(
                    new Car {
                        RegistrationMark = "AB12 BCD",
                        Make = "Ford",
                        Model = "Fiesta",
                        TrimLevel = "LX",
                        Mileage = 50000,
                        Colour = "Red",
                        Year = 2012,
                        Price = 2000,
                        Url = "Http://",
                        Location = "London",
                        DateAdded = DateTime.Now,
                        MotExpiry = 11
                    },
                    new Car {
                        RegistrationMark = "BC12 BCD",
                        Make = "BMW",
                        Model = "318i",
                        TrimLevel = "SE",
                        Mileage = 50000,
                        Colour = "Red",
                        Year = 2008,
                        Price = 3000,
                        Url = "Http://",
                        Location = "York",
                        DateAdded = DateTime.Now,
                        MotExpiry = 5
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
