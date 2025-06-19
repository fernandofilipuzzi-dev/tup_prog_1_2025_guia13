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
            FormVer formVer = new FormVer();

            servicio.OrdenarExpedientes();

            formVer.lsbResultados.Items.Clear();
            for (int n = 0; n < servicio.VerContador(); n++)
            {
                int nro, dni; double monto;
                servicio.VerExpediente(n, out nro, out dni, out monto);

                formVer.lsbResultados.Items.Add($"{nro} - {dni} - {monto,10}");
            }
            formVer.ShowDialog();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();

            int cantidad;
            int[] idxs=servicio.MayoresAlPromedio(out cantidad);

            formVer.lsbResultados.Items.Clear();
            for (int n = 0; n < cantidad; n++)
            {
                int idx= idxs[n];

                int nro, dni; double monto;
                servicio.VerExpediente(idx, out nro, out dni, out monto);

                formVer.lsbResultados.Items.Add($"{"Expediente",15} - {"DNI",10} - {"monto",10}");
                formVer.lsbResultados.Items.Add($"{nro,15} - {dni,10} - {monto,10:f2}");
            }
            formVer.ShowDialog();
        }

        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();

            int dniBuscar = Convert.ToInt32(tbDNI.Text);
            int cantidad;
            int[] idxs = servicio.VerExpedientesPorDNI(dniBuscar, out cantidad);

            formVer.lsbResultados.Items.Clear();
            for (int n = 0; n < cantidad; n++)
            {
                int idx = idxs[n];

                int nro;
                int dni;
                double monto;
                servicio.VerExpediente(idx, out nro, out dni, out monto);

                formVer.lsbResultados.Items.Add($"{"Expediente",15} - {"monto",10}");
                formVer.lsbResultados.Items.Add($"{nro,15} - {monto,10:f2}");
            }
            formVer.ShowDialog();
        }

        private void btnVerCausaPorNumero_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();

            int numeroCausa = Convert.ToInt32(tbNroCausa.Text);
            
            int idx = servicio.VerExpedientePorNumero(numeroCausa);

            formVer.lsbResultados.Items.Clear();
            
            int nro, dni; 
            double monto;

            servicio.VerExpediente(idx, out nro, out dni, out monto);

            formVer.lsbResultados.Items.Add($"{"Expediente",15} - {"DNI",10} - {"monto",10}");
            formVer.lsbResultados.Items.Add($"{nro,15} - {dni,10} - {monto,10:f2}");

            formVer.ShowDialog();
        }
    }
}
