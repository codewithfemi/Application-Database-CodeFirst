using IDE.Data.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace IDE.Data
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person {get; set;}
    }
}
