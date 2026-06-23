using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDP.DAL499NA;
using TDP.Servicios499NA;

namespace TDP.BLL499NA
{
    public class IdiomaBLL499NA
    {
        private IdiomaDAL499NA idiomaDAL = new IdiomaDAL499NA();

        public List<Idioma499NA> ObtenerListaIdiomas()
        {
            return idiomaDAL.ObtenerIdiomas();
        }
    }
}
