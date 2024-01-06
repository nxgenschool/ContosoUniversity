using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Station
    {
        public int ID { get; set; }
        public string StationName { get; set; }
        public string Address { get; set; }

        public int DivisionID { get; set; }

        public Division Division { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public string ModifiedBy { get; set; }

        public bool IsDelete { get; set; } = false;


    }
}
