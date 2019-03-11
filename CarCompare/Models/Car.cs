using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarCompare.Models {
    public class Car {
        public int Id { get; set; }
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

    }
}
