/*
* PRÁCTICA.............: Práctica 7.D:\ProyectosVisual\Practica7\Practica7\frmSplash.cs
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 17 de Diciembre de 2018
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    static class Aplicacion
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplash frmSplash = new frmSplash();
            if (frmSplash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmHojaSalarial());
            }
        }
    }
}
