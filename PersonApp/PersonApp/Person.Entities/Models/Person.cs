using System.ComponentModel.DataAnnotations;

namespace Person.Entities.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FristName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age {  get; set; }

    }
}
