using DocList.Data;
using DocList.Models.Ratings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocList.Services
{
    public class RatingsService : IRatingsService
    {
        private readonly ApplicationDbContext _context;
        public RatingsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CreateRating(RatingListItem rating)
        {
            throw new NotImplementedException();
        }

        public object DetailRatings()
        {
            throw new NotImplementedException();
        }

        public RatingListItem GetRating(int id)
        {
            throw new NotImplementedException();
        }

        public RatingListItem GetRating(string id)
        {
            throw new NotImplementedException();
        }

        public RatingListItem GetRating(RatingListItem rating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RatingListItem> GetRatings()
        {
            var Ratings = _context.Ratings
            .Select(r => new RatingListItem()
            {
                Name = r.JobType.Name,
                Score = r.Score,
                }).ToList();

            return Ratings;
        }

        public bool Rating(RatingListItem model)
        {
            throw new NotImplementedException();
        }
    }
}
