using System.ComponentModel.DataAnnotations;

namespace NullDto
{
    class Student 
    {
        // warning CS8618: Non-nullable property 'FirstName' is uninitialized. Consider declaring the property as nullable.
        [Required]
        public string FirstName { get; set; }

        // warning CS8618: Non-nullable property 'LastName' is uninitialized. Consider declaring the property as nullable.
        [Required]
        public string LastName { get; set; }

        // No warning here, this field is actually optional (note no [Required] field).
        public string? OptionalField { get; set; }
    }
}
