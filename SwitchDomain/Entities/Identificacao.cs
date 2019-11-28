namespace SwitchDomain.Entities
{
    public class Identificacao
    {
        public int id { get; set; }
        public EnumDocumento TipoDocumento { get; set; }
        public string NumeroDcumento { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}