using Microsoft.EntityFrameworkCore;
using Reservation.Review.Entities;

namespace Reservation.Review.Context
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {
            
        }

        public DbSet<UserReview> UserReviews { get; set; }
    }
}
