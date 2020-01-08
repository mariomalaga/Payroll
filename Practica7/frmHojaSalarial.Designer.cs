/*
* PRÁCTICA.............: Práctica 7.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 17 de Diciembre de 2018
*/
namespace Practica7
{
    partial class frmHojaSalarial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHojaSalarial));
            this.fplRellenar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblTrienios = new System.Windows.Forms.Label();
            this.cboTrienio = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.cboHoras = new System.Windows.Forms.ComboBox();
            this.lblHijos = new System.Windows.Forms.Label();
            this.cboHijos = new System.Windows.Forms.ComboBox();
            this.lblLiquidacion = new System.Windows.Forms.Label();
            this.dtpLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.fplCalculo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDevengos = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblCotizSeg = new System.Windows.Forms.Label();
            this.txtCotizSeg = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblCotizDes = new System.Windows.Forms.Label();
            this.txtCotizDes = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.lblPaga = new System.Windows.Forms.Label();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.lblTotalDev = new System.Windows.Forms.Label();
            this.txtTotalDev = new System.Windows.Forms.TextBox();
            this.lblTotalDesc = new System.Windows.Forms.Label();
            this.txtTotalDesc = new System.Windows.Forms.TextBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.erpControl = new System.Windows.Forms.ErrorProvider(this.components);
            this.ntiCalcular = new System.Windows.Forms.NotifyIcon(this.components);
            this.fplRellenar.SuspendLayout();
            this.fplCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fplRellenar
            // 
            this.fplRellenar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fplRellenar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fplRellenar.Controls.Add(this.lblDni);
            this.fplRellenar.Controls.Add(this.txtDni);
            this.fplRellenar.Controls.Add(this.lblNombre);
            this.fplRellenar.Controls.Add(this.txtNombre);
            this.fplRellenar.Controls.Add(this.lblCategoria);
            this.fplRellenar.Controls.Add(this.cboCategoria);
            this.fplRellenar.Controls.Add(this.lblTrienios);
            this.fplRellenar.Controls.Add(this.cboTrienio);
            this.fplRellenar.Controls.Add(this.lblHoras);
            this.fplRellenar.Controls.Add(this.cboHoras);
            this.fplRellenar.Controls.Add(this.lblHijos);
            this.fplRellenar.Controls.Add(this.cboHijos);
            this.fplRellenar.Controls.Add(this.lblLiquidacion);
            this.fplRellenar.Controls.Add(this.dtpLiquidacion);
            this.fplRellenar.Controls.Add(this.btnCalcular);
            this.fplRellenar.Location = new System.Drawing.Point(22, 16);
            this.fplRellenar.Name = "fplRellenar";
            this.fplRellenar.Size = new System.Drawing.Size(694, 206);
            this.fplRellenar.TabIndex = 52;
            this.fplRellenar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(10, 25);
            this.lblDni.Margin = new System.Windows.Forms.Padding(10, 25, 3, 50);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 17);
            this.lblDni.TabIndex = 52;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(47, 25);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 25, 100, 3);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(103, 22);
            this.txtDni.TabIndex = 53;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            this.txtDni.Leave += new System.EventHandler(this.txtDNI_LostFocus);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(253, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 22);
            this.txtNombre.TabIndex = 55;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress1);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(10, 95);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(10, 3, 3, 25);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 56;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategoria.Location = new System.Drawing.Point(85, 95);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(46, 24);
            this.cboCategoria.TabIndex = 63;
            // 
            // lblTrienios
            // 
            this.lblTrienios.AutoSize = true;
            this.lblTrienios.Location = new System.Drawing.Point(169, 95);
            this.lblTrienios.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.lblTrienios.Name = "lblTrienios";
            this.lblTrienios.Size = new System.Drawing.Size(78, 17);
            this.lblTrienios.TabIndex = 58;
            this.lblTrienios.Text = "Nº Trienios";
            // 
            // cboTrienio
            // 
            this.cboTrienio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrienio.FormattingEnabled = true;
            this.cboTrienio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboTrienio.Location = new System.Drawing.Point(253, 95);
            this.cboTrienio.Name = "cboTrienio";
            this.cboTrienio.Size = new System.Drawing.Size(56, 24);
            this.cboTrienio.TabIndex = 65;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(340, 95);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(28, 3, 3, 3);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(108, 17);
            this.lblHoras.TabIndex = 59;
            this.lblHoras.Text = "Nº Horas Extras";
            // 
            // cboHoras
            // 
            this.cboHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoras.FormattingEnabled = true;
            this.cboHoras.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cboHoras.Location = new System.Drawing.Point(454, 95);
            this.cboHoras.Name = "cboHoras";
            this.cboHoras.Size = new System.Drawing.Size(46, 24);
            this.cboHoras.TabIndex = 66;
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(538, 95);
            this.lblHijos.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(58, 17);
            this.lblHijos.TabIndex = 57;
            this.lblHijos.Text = "Nº Hijos";
            // 
            // cboHijos
            // 
            this.cboHijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHijos.FormattingEnabled = true;
            this.cboHijos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboHijos.Location = new System.Drawing.Point(602, 95);
            this.cboHijos.Name = "cboHijos";
            this.cboHijos.Size = new System.Drawing.Size(52, 24);
            this.cboHijos.TabIndex = 64;
            // 
            // lblLiquidacion
            // 
            this.lblLiquidacion.AutoSize = true;
            this.lblLiquidacion.Location = new System.Drawing.Point(10, 162);
            this.lblLiquidacion.Margin = new System.Windows.Forms.Padding(10, 25, 3, 3);
            this.lblLiquidacion.Name = "lblLiquidacion";
            this.lblLiquidacion.Size = new System.Drawing.Size(128, 17);
            this.lblLiquidacion.TabIndex = 60;
            this.lblLiquidacion.Text = "Periodo liquidación";
            this.lblLiquidacion.Click += new System.EventHandler(this.lblLiquidacion_Click);
            // 
            // dtpLiquidacion
            // 
            this.dtpLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLiquidacion.Location = new System.Drawing.Point(144, 162);
            this.dtpLiquidacion.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.dtpLiquidacion.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpLiquidacion.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpLiquidacion.Name = "dtpLiquidacion";
            this.dtpLiquidacion.Size = new System.Drawing.Size(111, 22);
            this.dtpLiquidacion.TabIndex = 62;
            this.dtpLiquidacion.Value = new System.DateTime(2018, 12, 15, 0, 0, 0, 0);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(408, 152);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(150, 15, 3, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 39);
            this.btnCalcular.TabIndex = 61;
            this.btnCalcular.Text = "Calcular Hoja Salarial";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // fplCalculo
            // 
            this.fplCalculo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fplCalculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fplCalculo.Controls.Add(this.lblDevengos);
            this.fplCalculo.Controls.Add(this.lblDescuentos);
            this.fplCalculo.Controls.Add(this.lblSalario);
            this.fplCalculo.Controls.Add(this.txtSalario);
            this.fplCalculo.Controls.Add(this.lblCotizSeg);
            this.fplCalculo.Controls.Add(this.txtCotizSeg);
            this.fplCalculo.Controls.Add(this.lblAntiguedad);
            this.fplCalculo.Controls.Add(this.txtAntiguedad);
            this.fplCalculo.Controls.Add(this.lblCotizDes);
            this.fplCalculo.Controls.Add(this.txtCotizDes);
            this.fplCalculo.Controls.Add(this.lblHorasExtras);
            this.fplCalculo.Controls.Add(this.txtHorasExtras);
            this.fplCalculo.Controls.Add(this.lblIRPF);
            this.fplCalculo.Controls.Add(this.txtIRPF);
            this.fplCalculo.Controls.Add(this.lblPaga);
            this.fplCalculo.Controls.Add(this.txtPaga);
            this.fplCalculo.Controls.Add(this.lblTotalDev);
            this.fplCalculo.Controls.Add(this.txtTotalDev);
            this.fplCalculo.Controls.Add(this.lblTotalDesc);
            this.fplCalculo.Controls.Add(this.txtTotalDesc);
            this.fplCalculo.Controls.Add(this.lblLiquido);
            this.fplCalculo.Controls.Add(this.txtLiquido);
            this.fplCalculo.Controls.Add(this.btnModificar);
            this.fplCalculo.Controls.Add(this.btnSalir);
            this.fplCalculo.Location = new System.Drawing.Point(22, 247);
            this.fplCalculo.Name = "fplCalculo";
            this.fplCalculo.Size = new System.Drawing.Size(679, 350);
            this.fplCalculo.TabIndex = 67;
            this.fplCalculo.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // lblDevengos
            // 
            this.lblDevengos.AutoSize = true;
            this.lblDevengos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevengos.Location = new System.Drawing.Point(10, 25);
            this.lblDevengos.Margin = new System.Windows.Forms.Padding(10, 25, 235, 20);
            this.lblDevengos.Name = "lblDevengos";
            this.lblDevengos.Size = new System.Drawing.Size(94, 17);
            this.lblDevengos.TabIndex = 0;
            this.lblDevengos.Text = "DEVENGOS";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentos.Location = new System.Drawing.Point(342, 25);
            this.lblDescuentos.Margin = new System.Windows.Forms.Padding(3, 25, 200, 3);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(113, 17);
            this.lblDescuentos.TabIndex = 1;
            this.lblDescuentos.Text = "DESCUENTOS";
            this.lblDescuentos.Click += new System.EventHandler(this.lblDescuentos_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(10, 65);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(10, 3, 22, 10);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(88, 17);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario Base";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(123, 65);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 3, 62, 3);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 22);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblCotizSeg
            // 
            this.lblCotizSeg.AutoSize = true;
            this.lblCotizSeg.Location = new System.Drawing.Point(338, 65);
            this.lblCotizSeg.Margin = new System.Windows.Forms.Padding(10, 3, 25, 3);
            this.lblCotizSeg.Name = "lblCotizSeg";
            this.lblCotizSeg.Size = new System.Drawing.Size(154, 17);
            this.lblCotizSeg.TabIndex = 4;
            this.lblCotizSeg.Text = "Cotiz. Seguridad Social";
            this.lblCotizSeg.Click += new System.EventHandler(this.lblCotizSeg_Click);
            // 
            // txtCotizSeg
            // 
            this.txtCotizSeg.Location = new System.Drawing.Point(520, 65);
            this.txtCotizSeg.Name = "txtCotizSeg";
            this.txtCotizSeg.Size = new System.Drawing.Size(143, 22);
            this.txtCotizSeg.TabIndex = 5;
            this.txtCotizSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(10, 95);
            this.lblAntiguedad.Margin = new System.Windows.Forms.Padding(10, 3, 30, 10);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(80, 17);
            this.lblAntiguedad.TabIndex = 6;
            this.lblAntiguedad.Text = "Antigüedad";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(123, 95);
            this.txtAntiguedad.Margin = new System.Windows.Forms.Padding(3, 3, 62, 3);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(143, 22);
            this.txtAntiguedad.TabIndex = 7;
            this.txtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCotizDes
            // 
            this.lblCotizDes.AutoSize = true;
            this.lblCotizDes.Location = new System.Drawing.Point(338, 95);
            this.lblCotizDes.Margin = new System.Windows.Forms.Padding(10, 3, 11, 3);
            this.lblCotizDes.Name = "lblCotizDes";
            this.lblCotizDes.Size = new System.Drawing.Size(168, 17);
            this.lblCotizDes.TabIndex = 8;
            this.lblCotizDes.Text = "Cotiz. Seguro Desempleo";
            this.lblCotizDes.Click += new System.EventHandler(this.lblCotizDes_Click);
            // 
            // txtCotizDes
            // 
            this.txtCotizDes.Location = new System.Drawing.Point(520, 95);
            this.txtCotizDes.Name = "txtCotizDes";
            this.txtCotizDes.Size = new System.Drawing.Size(143, 22);
            this.txtCotizDes.TabIndex = 9;
            this.txtCotizDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(10, 125);
            this.lblHorasExtras.Margin = new System.Windows.Forms.Padding(10, 3, 21, 10);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(89, 17);
            this.lblHorasExtras.TabIndex = 10;
            this.lblHorasExtras.Text = "Horas Extras";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(123, 125);
            this.txtHorasExtras.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(143, 22);
            this.txtHorasExtras.TabIndex = 11;
            this.txtHorasExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(336, 125);
            this.lblIRPF.Margin = new System.Windows.Forms.Padding(10, 3, 70, 3);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(106, 17);
            this.lblIRPF.TabIndex = 12;
            this.lblIRPF.Text = "Retención IRPF";
            this.lblIRPF.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtIRPF
            // 
            this.txtIRPF.Location = new System.Drawing.Point(515, 125);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(143, 22);
            this.txtIRPF.TabIndex = 13;
            this.txtIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaga
            // 
            this.lblPaga.AutoSize = true;
            this.lblPaga.Location = new System.Drawing.Point(10, 155);
            this.lblPaga.Margin = new System.Windows.Forms.Padding(10, 3, 33, 30);
            this.lblPaga.Name = "lblPaga";
            this.lblPaga.Size = new System.Drawing.Size(77, 17);
            this.lblPaga.TabIndex = 14;
            this.lblPaga.Text = "Paga Extra";
            // 
            // txtPaga
            // 
            this.txtPaga.Location = new System.Drawing.Point(123, 155);
            this.txtPaga.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(143, 22);
            this.txtPaga.TabIndex = 15;
            this.txtPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDev
            // 
            this.lblTotalDev.AutoSize = true;
            this.lblTotalDev.Location = new System.Drawing.Point(10, 205);
            this.lblTotalDev.Margin = new System.Windows.Forms.Padding(10, 3, 3, 50);
            this.lblTotalDev.Name = "lblTotalDev";
            this.lblTotalDev.Size = new System.Drawing.Size(108, 17);
            this.lblTotalDev.TabIndex = 16;
            this.lblTotalDev.Text = "Total Devengos";
            // 
            // txtTotalDev
            // 
            this.txtTotalDev.Location = new System.Drawing.Point(124, 205);
            this.txtTotalDev.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
            this.txtTotalDev.Name = "txtTotalDev";
            this.txtTotalDev.Size = new System.Drawing.Size(143, 22);
            this.txtTotalDev.TabIndex = 17;
            this.txtTotalDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.AutoSize = true;
            this.lblTotalDesc.Location = new System.Drawing.Point(337, 205);
            this.lblTotalDesc.Margin = new System.Windows.Forms.Padding(10, 3, 55, 10);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.Size = new System.Drawing.Size(119, 17);
            this.lblTotalDesc.TabIndex = 18;
            this.lblTotalDesc.Text = "Total Descuentos";
            // 
            // txtTotalDesc
            // 
            this.txtTotalDesc.Location = new System.Drawing.Point(514, 205);
            this.txtTotalDesc.Name = "txtTotalDesc";
            this.txtTotalDesc.Size = new System.Drawing.Size(143, 22);
            this.txtTotalDesc.TabIndex = 19;
            this.txtTotalDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Location = new System.Drawing.Point(10, 275);
            this.lblLiquido.Margin = new System.Windows.Forms.Padding(10, 3, 45, 10);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(64, 17);
            this.lblLiquido.TabIndex = 20;
            this.lblLiquido.Text = "LIQUIDO";
            // 
            // txtLiquido
            // 
            this.txtLiquido.Location = new System.Drawing.Point(122, 275);
            this.txtLiquido.Margin = new System.Windows.Forms.Padding(3, 3, 62, 3);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(143, 22);
            this.txtLiquido.TabIndex = 21;
            this.txtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(330, 275);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 41);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar Datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(521, 275);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 41);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // erpControl
            // 
            this.erpControl.ContainerControl = this;
            // 
            // ntiCalcular
            // 
            this.ntiCalcular.Visible = true;
            // 
            // frmHojaSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 562);
            this.Controls.Add(this.fplRellenar);
            this.Controls.Add(this.fplCalculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHojaSalarial";
            this.Text = "HojaSalarial";
            this.Load += new System.EventHandler(this.frmHojaSalarial_Load);
            this.fplRellenar.ResumeLayout(false);
            this.fplRellenar.PerformLayout();
            this.fplCalculo.ResumeLayout(false);
            this.fplCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fplRellenar;
        private System.Windows.Forms.ComboBox cboHoras;
        private System.Windows.Forms.ComboBox cboTrienio;
        private System.Windows.Forms.ComboBox cboHijos;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DateTimePicker dtpLiquidacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLiquidacion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblTrienios;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.FlowLayoutPanel fplCalculo;
        private System.Windows.Forms.Label lblDevengos;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblCotizSeg;
        private System.Windows.Forms.TextBox txtCotizSeg;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label lblCotizDes;
        private System.Windows.Forms.TextBox txtCotizDes;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.Label lblPaga;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.Label lblTotalDev;
        private System.Windows.Forms.TextBox txtTotalDev;
        private System.Windows.Forms.Label lblTotalDesc;
        private System.Windows.Forms.TextBox txtTotalDesc;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider erpControl;
        private System.Windows.Forms.NotifyIcon ntiCalcular;
    }
}

