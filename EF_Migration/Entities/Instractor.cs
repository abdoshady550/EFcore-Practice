namespace EF_Migration.Entities
{
    public class Instractor
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }

        public int? officeId { get; set; }

        public Office? office { get; set; }

        public ICollection<Section> sections { get; set; } = new List<Section>();

    }

}
