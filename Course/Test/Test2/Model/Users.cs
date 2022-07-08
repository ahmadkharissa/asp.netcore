using System.ComponentModel.DataAnnotations;

namespace Test2.Model {
    public class Users {

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