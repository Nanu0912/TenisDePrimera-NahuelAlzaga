using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDP.GUI499NA
{
    public partial class MenuPrincipal499NA : Form
    {
        public MenuPrincipal499NA()
        {
            InitializeComponent();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout499NA plogout = new Logout499NA();

            
            plogout.ShowDialog();

            
            
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContraseña499NA cc = new CambiarContraseña499NA();

            cc.ShowDialog();    
        }
    }
}
