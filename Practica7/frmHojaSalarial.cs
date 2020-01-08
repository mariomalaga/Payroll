/*
* PRÁCTICA.............: Práctica 7.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 17 de Diciembre de 2018
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class frmHojaSalarial : Form
    {
        public frmHojaSalarial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHojaSalarial_Load(object sender, EventArgs e)
        {
        }

        private void txtDNI_LostFocus(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("") || txtDni.Text.Length != 8)
            {
                erpControl.SetError(txtDni, "No ha terminado de rellenar el DNI");
            }
            else
            {
                string nif1 = txtDni.Text;
                int n = int.Parse(txtDni.Text);
                nif1 += CalcularLetra(n);
                txtDni.MaxLength = 9;
                txtDni.Text = nif1;
                erpControl.Clear();
            }
        }
        static char CalcularLetra(int n)
        {
            string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            return (char)cadena[n % 23];
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblLiquidacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int contador = 0;
            if (txtNombre.Text.Equals(""))
            {
                erpControl.SetError(txtNombre, "Ingresar nombre");
                contador++;
            }
            else
            {
                erpControl.Clear();
            }
            if (cboCategoria.SelectedIndex.Equals(-1))
            {
                erpControl.SetError(cboCategoria, "Seleccionar Categoría");
                contador++;
            }
            else
            {
                erpControl.Clear();
            }
            if (cboHijos.SelectedIndex.Equals(-1))
            {
                erpControl.SetError(cboHijos, "Seleccionar número hijos");
                contador++;
            }
            else
            {
                erpControl.Clear();
            }
            if (cboHoras.SelectedIndex.Equals(-1))
            {
                erpControl.SetError(cboHoras, "Seleccionar número horas");
                contador++;
            }
            else
            {
                erpControl.Clear();
            }
            if (cboTrienio.SelectedIndex.Equals(-1))
            {
                erpControl.SetError(cboTrienio, "Seleccionar número trienios");
                contador++;
            }
            else
            {
                erpControl.Clear();
            }
            if (contador == 0)
            {
                double porcentajeIRPF = 0;
                if (cboCategoria.SelectedItem.ToString().Equals("1"))
                {
                    txtSalario.Text = "2500";
                    porcentajeIRPF = Math.Round(18 - double.Parse(cboHijos.SelectedItem.ToString()), 2);
                }
                else if (cboCategoria.SelectedItem.ToString().Equals("2"))
                {
                    txtSalario.Text = "2000";
                    porcentajeIRPF = Math.Round(15 - double.Parse(cboHijos.SelectedItem.ToString()), 2);
                }
                else if (cboCategoria.SelectedItem.ToString().Equals("3"))
                {
                    txtSalario.Text = "1500";
                    porcentajeIRPF = Math.Round(12 - double.Parse(cboHijos.SelectedItem.ToString()), 2);
                }
                double antiguedad = Math.Round(double.Parse(cboTrienio.SelectedItem.ToString()) * double.Parse(txtSalario.Text) * 4 / 100, 2);
                txtAntiguedad.Text = antiguedad.ToString();
                double horasExtras = Math.Round(double.Parse(cboHoras.SelectedItem.ToString()) * double.Parse(txtSalario.Text) * 1 / 100, 2);
                txtHorasExtras.Text = horasExtras.ToString();
                double pagaExtra = Math.Round(double.Parse(txtSalario.Text) + double.Parse(txtAntiguedad.Text), 2);
                txtPaga.Text = pagaExtra.ToString();
                double totalDevengado = Math.Round(double.Parse(txtSalario.Text) + double.Parse(txtAntiguedad.Text) + double.Parse(txtHorasExtras.Text) + double.Parse(txtPaga.Text), 2);
                txtTotalDev.Text = totalDevengado.ToString();
                double retencionIRPF;
                if (dtpLiquidacion.Value.Month == 06 || dtpLiquidacion.Value.Month == 12)
                {
                    retencionIRPF = Math.Round((double.Parse(txtTotalDev.Text) + double.Parse(txtPaga.Text)) * porcentajeIRPF / 100, 2);
                }
                else
                {
                    retencionIRPF = Math.Round(double.Parse(txtTotalDev.Text) * porcentajeIRPF / 100, 2);
                }
                txtIRPF.Text = retencionIRPF.ToString();
                double baseCotizacion = Math.Round((double.Parse(txtPaga.Text) + double.Parse(txtPaga.Text)) / 6, 2);
                double cotizacionSegSoc = Math.Round(baseCotizacion * (4.51 / 100), 2);
                txtCotizSeg.Text = cotizacionSegSoc.ToString();
                double cotizacionSegDes = Math.Round(double.Parse(txtPaga.Text) * 1.97 / 100, 2);
                txtCotizDes.Text = cotizacionSegDes.ToString();
                double totalDes = Math.Round(double.Parse(txtCotizSeg.Text) + double.Parse(txtCotizDes.Text) + double.Parse(txtIRPF.Text), 2);
                txtTotalDesc.Text = totalDes.ToString();
                double liquido = Math.Round(double.Parse(txtTotalDev.Text) - double.Parse(txtTotalDesc.Text), 2);
                txtLiquido.Text = liquido.ToString();
                fplRellenar.Enabled = false;
                this.Size = new Size(555, 540);
                ntiCalcular.Icon = SystemIcons.Application;
                ntiCalcular.BalloonTipText = "Se ha calculado el salario";
                ntiCalcular.ShowBalloonTip(1000);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCotizDes_Click(object sender, EventArgs e)
        {

        }

        private void lblCotizSeg_Click(object sender, EventArgs e)
        {

        }

        private void lblDescuentos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(555, 230);
            fplRellenar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtCaracter_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
