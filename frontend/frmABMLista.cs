using backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class frmABMLista : Form
    {

        private Lista Lista = new Lista();

        public frmABMLista()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Lista.Agregar(txtNombre.Text);
            lblSalida.Text = Lista.Salida();
        }

        private void btModificarOri_Click(object sender, EventArgs e)
        {
            Lista.Modificar(txtNombreOri.Text, txtNombreNue.Text);
            lblSalida.Text = Lista.Salida();
        }
    }
}
