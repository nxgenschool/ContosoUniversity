using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        public int Credits { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}