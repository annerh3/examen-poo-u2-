namespace ProyectoExamenU2POO.Dtos.Clientes
{
    public class PrestamoDto
    {
        public Guid Id { get; set; }
        public string NombreCliente { get; set; }
        public int MontoPrestamo { get; set; }
        public int MontoComision { get; set; }
        public int TasaInteres { get; set; }
        public int Plazo { get; set; }
        public DateOnly FechaDesembolso { get; set; }
        public DateOnly FechaPrimerPago { get; set; }
    }
}
