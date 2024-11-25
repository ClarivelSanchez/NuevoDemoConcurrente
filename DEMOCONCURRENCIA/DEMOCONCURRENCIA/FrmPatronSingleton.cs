using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOCONCURRENCIA
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.cadenaConexion = TxtCadenadeConexion.Text;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            lblCadenaConexionRecuperada.Text = cadenaConexion.cadenaConexion;
        }
    }
}
