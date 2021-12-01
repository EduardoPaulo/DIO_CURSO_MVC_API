using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_CursoMVC.Models
{
    public class Context : DbContext
    {
        //Como criamos uma classe Categoria temos qe dizer ao EFF que teremos uma entidade homônima
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //Ele, o método, é o responsável por configurar o EFF. 
            //É dentro dele que especificaremos qual o db que iremos usar

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;DataBase=DIO_CursoMVC;Integrated Security=True");

        }
    }
}
