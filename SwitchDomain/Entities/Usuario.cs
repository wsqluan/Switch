using System;
using System.Collections;
using System.Collections.Generic;

namespace SwitchDomain.Entities
{
    public class Usuario
    {
        public int id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string UrlFoto { get; set; }
        public EnumSexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual Identificacao Identificacao { get; set; }
        public virtual ICollection<Postagem> postagens { get; set; }
        

    }
}