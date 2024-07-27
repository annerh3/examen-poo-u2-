using System.ComponentModel.DataAnnotations;

namespace ProyectoExamenU2POO.Dtos.Clientes
{
    public class PrestamoCreateDto
    {
        [Display(Name = "Nombre del cliente")]
        [Required(ErrorMessage = "El {0} es requerido.")]
    
        public string NombreCliente { get; set; }

        [Display(Name = "Monto del Prestamo")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int MontoPrestamo { get; set; }

        [Display(Name = "Monto de Comision")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public int MontoComision { get; set; }

        [Display(Name = "Tasa de Interes")]
        [Required(ErrorMessage = "La {0} es requerida.")]
        [Range(0, 100, ErrorMessage = "La {0} no es valida.")]
        public int TasaInteres { get; set; }

        [Display(Name = "Plazo en meses")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        [Range(0, 100, ErrorMessage = "El {0} no es valido.")]
        public int Plazo { get; set; }

        [Display(Name = "Fecha de desembolso")]
        [Required(ErrorMessage = "El {0} es requerida.")]
        public DateOnly FechaDesembolso { get; set; }

        [Display(Name = "Fecha del Primer Pago")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public DateOnly FechaPrimerPago { get; set; }

    }
}
