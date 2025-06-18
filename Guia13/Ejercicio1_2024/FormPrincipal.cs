using Parcial2.Models;
using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnAgregarExpediente_Click(object sender, EventArgs e)
        {
            FormRegistro fDatos=new FormRegistro();

            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                servicio.RegistrarExpediente(Convert.ToInt32(fDatos.tbNroCausa.Text), Convert.ToInt32(fDatos.tbDNI.Text), Convert.ToDouble(fDatos.tbMonto.Text));
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
