using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoExamenU2POO.Database.Entities
{
    [Table("pago", Schema = "dbo")]
    public class PagoEntity 
    {
       [Key]
       [Column("id")]
       public Guid Id { get; set; }

       [Display(Name = "Numero de Cuota")]
       [Column("num_cuota")]
       public int NumeroCuota { get; set; }

        [Display(Name = "Fecha de Pago")]
        [Column("fecha_pago")]
        public DateOnly FechaDePago { get; set; }

        [Column("interes")]
        public double Interes {  get; set; }
        [Column("principal")]
        public double Principal { get; set; }
        [Column("cuota_sin_svsd")]
        public double CuotaSinSvsd { get; set; }
        [Column("cuota_con_svsd")]
        public double CuotaConSVSD { get; set; }
        [Column("saldo_principal")]
        public double SaldoPrincipal { get; set; }

        // public virtual IEnumerable<PrestamoEntity> Prestamos { get; set; }
    }
}
