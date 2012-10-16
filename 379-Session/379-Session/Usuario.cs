using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _379_Session
{
    public class Usuario
    {
        public String Id { get; set; }
        public String Senha { get; set; }

        public Usuario(String id, String senha)
        {
            this.Id = id;
            this.Senha = senha;
        }

        public override bool Equals(object obj)
        {
            Usuario outro = (Usuario)obj;
            return this.Id.Equals(outro.Id) && this.Senha.Equals(outro.Senha);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() + this.Senha.GetHashCode();
        }
    }
}