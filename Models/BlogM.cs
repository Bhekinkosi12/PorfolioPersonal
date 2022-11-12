namespace Porfolio.Models
{
    public class BlogM
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Header { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = "";
    }
}
