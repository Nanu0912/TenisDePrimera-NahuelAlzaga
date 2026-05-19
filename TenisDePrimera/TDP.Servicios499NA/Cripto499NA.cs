using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TDP.Servicios499NA
{
    public class Cripto499NA
    {
        
        private static Cripto499NA instancia499NA = null;
        private Cripto499NA() { }

        public static Cripto499NA Instancia499NA
        {
            get
            {
                if (instancia499NA == null)
                {
                    instancia499NA = new Cripto499NA();
                }
                return instancia499NA;
            }
        }
        public string Encriptar499NA(string textoPlano499NA)
        {
            using (SHA256 sha256499NA = SHA256.Create())
            {
                byte[] bytes499NA = sha256499NA.ComputeHash(Encoding.UTF8.GetBytes(textoPlano499NA));
                StringBuilder constructorTexto499NA = new StringBuilder();
                for (int i499NA = 0; i499NA < bytes499NA.Length; i499NA++)
                {
                    constructorTexto499NA.Append(bytes499NA[i499NA].ToString("x2"));
                }
                return constructorTexto499NA.ToString();
            }
        }
    }
}
