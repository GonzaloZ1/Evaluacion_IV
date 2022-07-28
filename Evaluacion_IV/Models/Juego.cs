using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion_IV.Models
{
    [Table("Juego")]
    public class Juego
    {
        public int Id { get; set; }
        public int EstudioId { get; set; }
        public string Nombre { get; set; }
        public int UnidadesVendidas { get; set; }
        
        public virtual Estudio Estudio { get; set; }
    }
}

