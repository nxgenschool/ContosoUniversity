namespace ContosoUniversity.Models
{
    public class Division
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Station> Stations { get; set; }
    }
}
