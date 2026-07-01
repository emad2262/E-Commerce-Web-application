using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Web_application.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext()
        {
            
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
