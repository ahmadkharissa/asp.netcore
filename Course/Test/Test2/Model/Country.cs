using System.ComponentModel.DataAnnotations;

namespace Test2.Model {
    public class Country {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}