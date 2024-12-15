using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviews1.Data;
using MovieReviews1.Models;

namespace MovieReviews1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieReviews1.Data.ReviewsContext _context;

        public IndexModel(MovieReviews1.Data.ReviewsContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Games.ToListAsync();
        }
    }
}
