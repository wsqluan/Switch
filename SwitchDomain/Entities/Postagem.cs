using System;

namespace SwitchDomain.Entities
{
    public class Postagem
    {
        public int id { get; private set; }
        public string Descricao { get; set; }
        public string UrlMidia { get; set; }
        public DateTime DataPub { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}