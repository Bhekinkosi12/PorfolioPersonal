

using Porfolio.Models;

namespace Porfolio.Services.Project
{
    public interface IProductServices
    {
        Task<List<ProjectM>> GetProjects();
        Task<ProjectM?> GetProject(string id);

    }
}
