using Microsoft.EntityFrameworkCore;
using chamadosTeste.Models;

namespace chamadosTeste.data
{

    public dataContext : DbContext
    {
        public dataContext(dbContextOptins<dataContext> options)
            : base(options)
        {
        }

        public DbSet<Chamado> Chamado { get; set; }
        public DbSet<Acoes> Acoes { get; set; }
    }

}