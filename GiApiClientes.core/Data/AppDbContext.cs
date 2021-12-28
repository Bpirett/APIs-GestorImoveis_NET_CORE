using GiApiClientes.core.Models;
using Microsoft.EntityFrameworkCore;

namespace GiApiClientes.core.Data
{
    public class AppDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=GestorImoveis.db;Cache=Shared");


        public DbSet<Cliente> Clientes { get; set; }
    }
}
