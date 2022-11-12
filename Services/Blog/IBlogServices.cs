using Porfolio.Models;

namespace Porfolio.Services.Blog
{
    public interface IBlogServices
    {
        Task<BlogM?> GetBlogById(string id);
        Task<List<BlogM>> GetAllAllBlogs();
        Task<bool> CreateBlog(BlogM blog);
    }
}
