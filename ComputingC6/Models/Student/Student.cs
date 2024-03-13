using System.ComponentModel.DataAnnotations;

namespace ComputingC6.Models.Student
{
    public class Student
    {
        [Key]
        public int LMUID { get; set; }

        public String Name { get; set; }
        public String Email { get; set; }
        public String fypTitle { get; set; }

    }
}
