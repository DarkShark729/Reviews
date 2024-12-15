using Microsoft.EntityFrameworkCore;
using MovieReviews1.Models;

namespace MovieReviews1.Data
{
    public class ReviewsContext: DbContext
    {
        public ReviewsContext(DbContextOptions<ReviewsContext> options) : base(options) 
        {
        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Review> reviews { get; set; }


    }
}
