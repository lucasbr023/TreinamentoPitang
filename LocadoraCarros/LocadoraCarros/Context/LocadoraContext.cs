using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class LocadoraContext : DbContext {

        public LocadoraContext() : base(@"Data Source=(local)\LUCASSQLSERVER; Initial Catalog=LocadoraCarros;Integrated Security=true") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }

        

    }
}
