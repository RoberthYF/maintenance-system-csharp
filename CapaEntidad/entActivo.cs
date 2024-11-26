namespace CapaEntidad
{
    public class entActivo
    {

        public int Id { get; set; }
        public entTipoActivo TipoActivo { get; set; }

        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public string Placa { get; set; }
        public bool Estado { get; set; }

    }
}
