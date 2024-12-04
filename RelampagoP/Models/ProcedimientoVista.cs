using System.ComponentModel.DataAnnotations;

namespace RelampagoP.Models
{
    public class ProcedimientoVista
    {
        [Key]
        public int idProcedimiento { get; set; }
        public string? nombreProcedimiento { get; set; }
        public string? nombreMacroproceso { get; set; }
        public string? nombreArea { get; set; }
        public string? nombreDependencia { get; set; }
        public string? nombreEjeEstrategico { get; set; }
        public int? anioActualizacion { get; set; }
        public string? estado { get; set; }
        public string? tipoProcedimiento { get; set; }
        public string? teletrabajado { get; set; }
    }
}
