using Microsoft.AspNetCore.Mvc;
using MiPortafolioMVC.Services;

public class ProjectsController : Controller
{
    private readonly ProjectService _service;

    public ProjectsController(ProjectService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var projects = _service.GetProjects();
        return View(projects);
    }
}