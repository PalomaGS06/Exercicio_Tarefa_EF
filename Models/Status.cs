using System.ComponentModel.DataAnnotations;

namespace ListaTarefas.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
    }
}
