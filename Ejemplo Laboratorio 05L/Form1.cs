using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Laboratorio_05L
{
    public partial class Ejemplo : Form
    {
        public Ejemplo()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Este es un ejemplo en programación en C#";
        }

        private void lblSaludo_TextChanged(object sender, EventArgs e)
        {
            lblCambio.Text = "Error 404, el mensaje anterior no existe";
        }

        private void cbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCambio.Text = cbMaterias.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            lblInscripcion.Text = "Hola, " + txtNombre.Text+
                             " la materia inscrita es: " + cbMaterias.Text;
        }
    }
}
