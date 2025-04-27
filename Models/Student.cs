// use validation attributes ex - [Required]
using System.ComponentModel.DataAnnotations;

namespace StudentCrudApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public string Course { get; set; }
    }
}
