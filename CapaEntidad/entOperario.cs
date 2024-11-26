namespace CapaEntidad
{
    public class entOperario
    {
        public int  Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
        public string Dni { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public bool Estado { get; set; }

    }
}
