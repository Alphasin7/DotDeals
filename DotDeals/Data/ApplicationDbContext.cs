using Microsoft.EntityFrameworkCore;

namespace DotDeals.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
    }
}
