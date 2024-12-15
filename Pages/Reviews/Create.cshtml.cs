using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieReviews1.Data;
using MovieReviews1.Models;

namespace MovieReviews1.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly MovieReviews1.Data.ReviewsContext _context;

        public CreateModel(MovieReviews1.Data.ReviewsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GameId"] = new SelectList(_context.Games, "GameId", "GameId");
            return Page();
        }

        [BindProperty]
        public Review review { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.reviews.Add(review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
