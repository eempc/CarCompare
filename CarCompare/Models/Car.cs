using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarCompare.Models {
    public class Car {
        public int Id { get; set; }

        [Display(Name = "Reg.")]
        public string RegistrationMark { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string TrimLevel { get; set; }
        public int Mileage { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Url { get; set; }
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public int MotExpiry { get; set; }
        // The 6 step method to add a new column: 
        // (1) add here in Car.cs 
        // (2) then add the two Bind in CarsController.cs
        // (3) then modify each of the cshtml CRUD pages
        // (4) add the SeedData just in case
        // (5) then Build the solution
        // (6) Then migrate to update the dbo
    }
}
