using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaSSAdvogados.Models
{
    public class AdvogaciaContext : DbContext
    {
        public AdvogaciaContext() : base("Advogacia")
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Cliente> Clientes { get; set; }
        
    }
}