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
        private ListaSinRepetidos Lista = new ListaSinRepetidos();

        public frmABMLista()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //string res = Lista.Agregar(txtNombre.Text);
            //if(res != "")
            //{
            //    lblMensaje.Text = res;
            //}
            //lblMensaje.Text = res;
            lblMensaje.Text= Lista.Agregar(txtNombre.Text); ;
            lblSalida.Text = Lista.Salida();
        }

        private void btModificarOri_Click(object sender, EventArgs e)
        {
            Lista.Modificar(txtNombreOri.Text, txtNombreNue.Text);
            lblSalida.Text = Lista.Salida();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int i = Lista.Buscar(txtNombre.Text);
            if (i == -1)
            {
                lblMensaje.Text = "No se encontró a " + txtNombre.Text;
            }
            else
            {
                lblMensaje.Text = "El nombre "
                                  + txtNombre.Text
                                  + " se encuentra en la fila "
                                  + (i + 1).ToString();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
             if( Lista.Eliminar(txtNombre.Text))
             {
                lblSalida.Text = Lista.Salida();
                lblMensaje.Text = "";
             }
             else
             {
                lblMensaje.Text = "El nombre " + txtNombre.Text + " NO se ha borrado";
             }
        }
    }
}
