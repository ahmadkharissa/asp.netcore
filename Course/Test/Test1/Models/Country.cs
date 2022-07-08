using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.Models {
    public class Country {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
