using ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefas.Contexts
{
    public class ListaTarefaContext : DbContext
    {
        public ListaTarefaContext(DbContextOptions<ListaTarefaContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Status> Status { get; set; }

    }
}
