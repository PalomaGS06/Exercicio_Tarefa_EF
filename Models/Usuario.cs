using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListaTarefas.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ICollection<Tarefa> Tarefas { get; set; }
    }
}
