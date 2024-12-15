using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviews1.Data;
using MovieReviews1.Models;

namespace MovieReviews1.Pages.Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly MovieReviews1.Data.ReviewsContext _context;

        public DetailsModel(MovieReviews1.Data.ReviewsContext context)
        {
            _context = context;
        }

        public Review review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.reviews.FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }
            else
            {
                review = review;
            }
            return Page();
        }
    }
}
