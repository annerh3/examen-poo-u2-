using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoExamenU2POO.Database.Entities
{
    [Table("prestamo_pago", Schema = "dbo")]
    public class PrestamoPagoEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("prestamo_id")]
        public Guid PrestamoId { get; set; }
        [ForeignKey(nameof(PrestamoId))]
        public virtual PrestamoEntity Prestamo { get; set; }

        [Column("pago_id")]
        public Guid PagoId { get; set; }
        [ForeignKey(nameof(PagoId))]
        public virtual PagoEntity Pago { get; set; }
    }
}
