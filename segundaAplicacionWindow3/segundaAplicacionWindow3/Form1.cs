using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundaAplicacionWindow3
{
    public partial class formDatosPersonales : Form
    {
        public formDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceeptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;


            txtResultado.Text = "NOMBRE: " + txtNombre.Text + Environment.NewLine + "APELLIDO: " +
                txtApellido.Text + Environment.NewLine + "EDAD: " + txtEdad.Text + Environment.NewLine +
                "DIRECCION: " + txtDireccion.Text;
        }

        private void btnAceeptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceeptar.Cursor = Cursors.Hand;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceeptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceeptar.Cursor = Cursors.Arrow;
        }

    }  
}
