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
            return View(JobType);
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(JobTypesCreateModel model)
            {
                if (!ModelState.IsValid)
                {
                    TempData["ErrorMsg"] = "Model State is Invalid";
                    return View(model);
                }
                -ctx.JobType.Add(new JobType
                {
                    Name = model.Name,
                    Deadline = model.Deadline,
                    Description = model.Description,
                });
                if (_ctx.SaveChanges() == 1)
                {
                    return Redirect("/JobTypes");
                }
                TempData["ErrorMsg"] = "Unable to save to the database. Please try again later.";
                return View(model);
            }

        }
    }
}

