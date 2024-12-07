using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IHCATCadClientes.Models;

namespace IHCATCadClientes.Data
{
    public class IHCATCadClientesContext : DbContext
    {
        public IHCATCadClientesContext (DbContextOptions<IHCATCadClientesContext> options)
            : base(options)
        {
        }

        public DbSet<IHCATCadClientes.Models.Cliente> Cliente { get; set; } = default!;

    }
}
