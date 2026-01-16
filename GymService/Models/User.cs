using System.Collections.Generic;

namespace GymService.Models
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> EnrolledCourses { get; set; } = new List<string>();
    }
}
