using Microsoft.EntityFrameworkCore;


namespace SocialApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options)
        {
            
        }

    }
}