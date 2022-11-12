namespace Porfolio.Models
{
    public class IndexViewModel
    {
        public IndexViewModel() {
         Projects = new List<ProjectM>();
            Blogs = new List<BlogM>();
        }
        public List<ProjectM> Projects { get; set; } 
        public List<BlogM> Blogs { get; set; }
    }
}
