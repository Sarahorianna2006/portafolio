using portafolio.Models;

namespace MiPortafolioMVC.Services
{
    public class ProjectService
    {
        public List<Project> GetProjects()
        {
            return new()
            {
                new Project { Title="Proyecto 1", Description="Descripción proyecto 1", Image="proj1.png" },
                new Project { Title="Proyecto 2", Description="Descripción proyecto 2", Image="proj2.png" }
            };
        }
    }
}