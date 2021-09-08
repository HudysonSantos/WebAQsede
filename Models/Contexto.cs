using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAQsede.Models.Dominio;

namespace WebAQsede.Models
{
    public class Contexto:DbContext
    { 

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes{ get; set; }

        public DbSet<Entregador> Entregadores { get; set; }

        public DbSet<Estabelecimentos> Estabelecimentos{ get; set; }
    }
}
