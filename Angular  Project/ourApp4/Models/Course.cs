using System.ComponentModel.DataAnnotations;

namespace ourApp4.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CName { get; set; }
        public int CFee { get; set; }
        public bool Status { get; set; }
        public string Technology { get; set; }      

    }
}
