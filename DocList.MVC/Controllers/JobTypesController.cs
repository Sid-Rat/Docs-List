//using DocList.MVC.Data;
//using DocListDbContext;
using DocList.Data;
using DocList.Models.JobTypes;
using Microsoft.AspNetCore.Mvc;

namespace DocList.MVC.Controllers
{
    public class JobTypesController : Controller
    {
        private readonly ApplicationDbContext _ctx;
        public JobTypesController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var jobTypes = _ctx.JobTypes.Select(jobTypes => new JobTypesIndexModel
            {
                Id = jobTypes.Id,
                Name = jobTypes.Name,
                Deadline = jobTypes.Deadline,
                Description = jobTypes.Description,
            });
            return View();
        }
    }
}
