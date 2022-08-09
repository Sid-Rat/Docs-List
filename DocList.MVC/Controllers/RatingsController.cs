using DocList.Models.Ratings;
using DocList.Ratings;
using DocList.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocList.Controllers
{
    public class RatingsController : Controller


    {
        private readonly IRatingsService _ratings;
        public RatingsController(IRatingsService ratingService)
        {
            _ratings = ratingService;
        }

        // GET: RatingsController
        public IActionResult RatingIndex()
        {
            var getRating = _ratings.GetRatings();
            return View(getRating);
        }

        // GET: RatingsController/Details/5
        public IActionResult RatingDetails()
        {
            var getRating = (_ratings.GetRatings());
            return View();
        }

        // GET: RatingsController/Create
        public IActionResult RatingCreate()
        {
            return View();
        }

        // POST: RatingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RatingCreate(RatingsCreate model)
        { 
            if (!ModelState.IsValid)
                return View(model);

            if (_ratings.Rating(model))
                return RedirectToAction("Index");

            return View(model);
        }

        // GET: RatingsController/Edit/5
        public IActionResult RatingEdit(int id)
        {
            return View();
        }

        // POST: RatingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RatingEdit(RatingsIndex model)
        {
            try
            {
                return RedirectToAction(nameof(RatingIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: RatingsController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: RatingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(RatingIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
