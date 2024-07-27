namespace ProyectoExamenU2POO.Dtos.Clientes
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int MontoPrestamo { get; set; }
        public int MontoComision { get; set; }
        public int TasaInteres { get; set; }
        public int Plazo { get; set; }
        public string FechaDesembolso { get; set; }
        public string FechaPrimerPago { get; set; }
    }
}
