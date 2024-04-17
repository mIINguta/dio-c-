using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApi.Entities;

namespace webApi.Context
{
    public class AgendaContext : DbContext
    {
        //abaixo representa a entrada de confg de banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){
            
        }
        // recebe dados da tabela
        public DbSet<Contato> Contatos {get; set;}
    }
}