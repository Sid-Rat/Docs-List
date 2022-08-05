using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocList.Models;
using DocList.Models.Ratings;

namespace DocList.Services
{
    public interface IRatingsService
    {
        bool CreateRating(RatingListItem rating);
        IEnumerable<RatingListItem> GetRatings();
        RatingListItem GetRating(int id);
        RatingListItem GetRating(string id);
        RatingListItem GetRating(RatingListItem rating);
        bool Rating(RatingListItem model);
    }
}
