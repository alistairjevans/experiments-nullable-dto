using System.ComponentModel.DataAnnotations;

namespace NullDto
{
    // From the perspective of the application, the [Required] fields are not optional, but are often 
    // populated automatically by a deserialiser. So there is an empty constructor to allow for that, which
    // results in the below warnings.
    class Student 
    {
        // warning CS8618: Non-nullable property 'FirstName' is uninitialized. Consider declaring the property as nullable.
        // warning CS8618: Non-nullable property 'LastName' is uninitialized. Consider declaring the property as nullable.
        public Student()
        {
            // Empty constructor used for deserialisation. 
        }

        public Student(string firstName, string lastName)
        {            
            // Constructor used when creating a new Student in code.
            FirstName = firstName;
            LastName = lastName;
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // No warning here, this field is actually optional (note no [Required] attribute).
        public string? OptionalField { get; set; }
    }
}
