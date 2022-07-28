using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion_IV.Models
{
    [Table("Estudio")]
    public class Estudio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly Fundacion { get; set; }
        public bool Consola { get; set; }
        public int? Empleados { get; set; }
        
        public virtual ICollection<Juego> Juegos { get; set; }
    }
}