using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDP.GUI499NA
{
    public class Navegador499NA
    {
        private static Form _formularioActivo = null;

        public static void CambiarPantalla(Form nuevaPantalla)
        {
            if (nuevaPantalla == null) return;

            if (_formularioActivo != null)
            {
                _formularioActivo.Hide(); 
                _formularioActivo.Dispose(); 
            }

            _formularioActivo = nuevaPantalla;

            _formularioActivo.StartPosition = FormStartPosition.CenterScreen;

            _formularioActivo.FormClosed += (sender, e) =>
            {
                if (Application.OpenForms.Count == 0 || (sender == _formularioActivo && NuevaPantallaEsPrincipal(sender)))
                {
                    Application.Exit();
                }
            };

            _formularioActivo.Show();
        }

        private static bool NuevaPantallaEsPrincipal(object sender)
        {
            return sender.GetType().Name.Contains("Login") || sender.GetType().Name.Contains("MenuPrincipal");
        }
    }
}
