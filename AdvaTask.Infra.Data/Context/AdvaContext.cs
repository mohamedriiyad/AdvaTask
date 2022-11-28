using Microsoft.EntityFrameworkCore;

namespace AdvaTask.Infra.Data.Context
{
    public class AdvaContext : DbContext
    {
        public AdvaContext(DbContextOptions<AdvaContext> options)
            : base(options)
        {

        }
    }
}
