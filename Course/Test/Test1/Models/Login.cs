using System.ComponentModel.DataAnnotations;

namespace Test.Models {
    public class Login {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        public Country Country { get; set; }
    }
}
