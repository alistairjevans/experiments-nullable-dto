using System.ComponentModel.DataAnnotations;

namespace NullDto
{
    class Student 
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
