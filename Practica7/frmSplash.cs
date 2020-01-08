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
    public partial class frmSplash : Form
    {
        private int contador = 0;
        public frmSplash()
        {
            InitializeComponent();
            tmrCargar.Enabled = true;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            contador++;
            lblCargando.Text = "CARGANDO: " + contador + " %";
            progressBarCargar.Increment(1);
            if (progressBarCargar.Value == 100)
            {
                tmrCargar.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void progressBarCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
