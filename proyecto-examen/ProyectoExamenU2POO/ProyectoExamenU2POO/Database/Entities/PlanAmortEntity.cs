using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoExamenU2POO.Database.Entities
{
    [Table("plan_amortiguacion", Schema = "dbo")]
    public class PlanAmortEntity // Plan de Amortiguación
    {
       [Column("num_cuota")]
       public int NumeroCuota { get; set; }

        [Column("fecha_pago")]
        public string FechaDePago { get; set; }

        [Column("interes")]
        public decimal Interes {  get; set; }
        [Column("principal")]
        public decimal Principal { get; set; }
        [Column("cuota_sin_svsd")]
        public decimal CuotaSinSvsd { get; set; }
        [Column("cuota_con_svsd")]
        public decimal CuotaConSVSD { get; set; }
        [Column("saldo_principal")]
        public decimal SaldoPrincipal { get; set; }
    }
}
