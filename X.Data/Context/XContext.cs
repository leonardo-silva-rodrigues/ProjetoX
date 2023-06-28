using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Core.Domain;

namespace X.Data.Context
{
    public class XContext : DbContext
    {
        public XContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
