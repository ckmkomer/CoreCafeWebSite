namespace CafeWebSite.Models
{
    public class ResarvationViewModel
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Number { get; set; }
        public string? Phone { get; set; }

        public DateTime Date { get; set; }

        public string? ThayDay { get; set; }
        public string? Message { get; set; }
    }
}
