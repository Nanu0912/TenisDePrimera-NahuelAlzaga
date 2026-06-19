using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDP.Servicios499NA
{
    public class Componente499NA
    {
        public int ID_Componente { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool EsFamilia { get; set; }
        public int? ID_Padre { get; set; }

        // El corazón del  Composite: La lista de hijos que contiene esta rama
        public List<Componente499NA> Hijos { get; set; } = new List<Componente499NA>();

        public void AgregarHijo(Componente499NA hijo)
        {
            if (EsFamilia)
            {
                Hijos.Add(hijo);
            }
        }
    }
}
