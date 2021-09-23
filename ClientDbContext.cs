using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using TesteProCondutor.Model;

namespace TesteProCondutor.Context
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clientes { get; set; }
    }
}
