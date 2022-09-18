using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListaTarefas.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Status")]
        public int IdStatus { get; set; }
        public Status Status { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public string Descricao { get; set; }


    }
}
