using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Test.Models;

namespace Test.DTO {
    public class LoginCountry {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        public int countryId { get; set; }

        public List<Country> Countries { get; set; }
    }
}
