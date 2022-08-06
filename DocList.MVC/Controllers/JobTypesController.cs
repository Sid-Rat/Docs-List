using DocList.Models.JobTypes;
using DocList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocList.Controllers
{
    public class JobTypesController : Controller
    {
        private readonly IJobTypeService _jobTypeService;
        public JobTypesController(IJobTypeService jtService)
        {
            _jobTypeService = jtService;
        }

        public IActionResult Index()    
        { 
            var jobTypes = _jobTypeService.GetJobTypes();
            return View(jobTypes);
        }
         
        public IActionResult Details()
        {
            var jobTypes = _jobTypeService.DetailJobJypes();
            return View(jobTypes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobTypesCreateModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (_jobTypeService.CreateJobTypes(model))
                return RedirectToAction("Index");

            return View(model); 
        }
        public IActionResult Edit(int Id)
        {
            var jobs = _jobTypeService.GetJobTypeById(Id);
            if (jobs == null)
            {
                return NotFound();
            }
            var model = new JobTypesEditModel
            {
                Id = jobs.Id,
                Name = jobs.Name,
                Deadline = jobs.Deadline,
                Description = jobs.Description,

            };
            return View(model);


          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JobTypesEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (_jobTypeService.EditJobTypes(model))
                return RedirectToAction("Index");

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
