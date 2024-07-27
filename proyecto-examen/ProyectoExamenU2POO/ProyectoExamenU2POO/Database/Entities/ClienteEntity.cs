using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoExamenU2POO.Database.Entities
{
    [Table("clientes", Schema = "dbo")]
    public class ClienteEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} de la categoria es requerido.")]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Monto del Prestamo")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [Column("monto_prestano")]
        public int MontoPrestamo { get; set; }

        [Display(Name = "Monto de Comision")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [Column("monto_comision")]
        public int MontoComision { get; set; }

        [Display(Name = "Tasa de Interes")]
        [Required(ErrorMessage = "La {0} es requerida.")]
        [Column("tasa_interes")]
        public int TasaInteres { get; set; }

        [Display(Name = "Plazo en meses")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [Column("plazo")]
        public int Plazo {  get; set; }

        [Display(Name = "Fecha de desembolso")]
        [Required(ErrorMessage = "El {0} es requerida.")]
        [Column("fecha_desembolso")]
        public string FechaDesembolso { get; set; }

        [Display(Name = "Fecha del Primer Pago")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [Column("fecha_primer_pago")]
        public string FechaPrimerPago { get; set; }
    }
}
