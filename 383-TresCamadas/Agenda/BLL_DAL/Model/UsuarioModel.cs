using System;
using System.Data.Linq.Mapping;

namespace BLL_DAL.Model
{
    [Table(Name = "USUARIO")]
    public class UsuarioModel
    {
        [Column(Name = "COD_USUARIO", IsPrimaryKey = true, IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
        public int CodUsuario { get; set; }

        [Column(Name = "NOME_USUARIO", UpdateCheck = UpdateCheck.Never)]
        public String NomeUsuario { get; set; }

        private String pwdUsuario;

        [Column(Name = "PWD_USUARIO", UpdateCheck = UpdateCheck.Never)]
        public String PwdUsuario
        {
            get
            {
                //return Util.Criptografia.Decriptar(this.pwdUsuario);
                return this.pwdUsuario;
            }
            set
            {
                this.pwdUsuario = Util.Criptografia.Encriptar(value);
            }
        }

        [Column(Name = "ADM_USUARIO", UpdateCheck = UpdateCheck.Never)]
        public char AdmUsuario { get; set; }
    }
}