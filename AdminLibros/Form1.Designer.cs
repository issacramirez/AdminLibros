
using System;

namespace AdminLibros {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMensajeRegistro = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCantidadLibros = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickHasta = new System.Windows.Forms.DateTimePicker();
            this.datePickDesde = new System.Windows.Forms.DateTimePicker();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numAgregarCopia = new System.Windows.Forms.NumericUpDown();
            this.numAgregarAnio = new System.Windows.Forms.NumericUpDown();
            this.numAgregarCodBarr = new System.Windows.Forms.NumericUpDown();
            this.numAgregarBibId = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregarFondo = new System.Windows.Forms.TextBox();
            this.txtAgregarEdicion = new System.Windows.Forms.TextBox();
            this.txtAgregarTitulo = new System.Windows.Forms.TextBox();
            this.txtAgregarEt264 = new System.Windows.Forms.TextBox();
            this.txtAgregarEditorial = new System.Windows.Forms.TextBox();
            this.txtAgregarAutor = new System.Windows.Forms.TextBox();
            this.txtAgregarUnid = new System.Windows.Forms.TextBox();
            this.txtAgregarClasEjem = new System.Windows.Forms.TextBox();
            this.txtAgregarClaseEjem = new System.Windows.Forms.TextBox();
            this.txtAgregarEstado = new System.Windows.Forms.TextBox();
            this.txtAgregarClasBib = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtLibrosEncontrados = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panelConsultaLib = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.numEliminarCodBarr = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarCopia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarCodBarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarBibId)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEliminarCodBarr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 164);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(168, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro de Libros de uso en sala de lectura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Libro";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.lblMensajeRegistro);
            this.tabPage1.Controls.Add(this.txtAutor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLibro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            // 
            // lblMensajeRegistro
            // 
            this.lblMensajeRegistro.AutoSize = true;
            this.lblMensajeRegistro.Location = new System.Drawing.Point(269, 273);
            this.lblMensajeRegistro.Name = "lblMensajeRegistro";
            this.lblMensajeRegistro.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeRegistro.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(436, 162);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(323, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Autor";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(436, 206);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(323, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // txtLibro
            // 
            this.txtLibro.Enabled = false;
            this.txtLibro.Location = new System.Drawing.Point(436, 117);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(323, 20);
            this.txtLibro.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.txtCantidadLibros);
            this.tabPage2.Controls.Add(this.btnGenerar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.datePickHasta);
            this.tabPage2.Controls.Add(this.datePickDesde);
            this.tabPage2.Controls.Add(this.panelResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            // 
            // txtCantidadLibros
            // 
            this.txtCantidadLibros.Enabled = false;
            this.txtCantidadLibros.Location = new System.Drawing.Point(109, 112);
            this.txtCantidadLibros.Name = "txtCantidadLibros";
            this.txtCantidadLibros.ReadOnly = true;
            this.txtCantidadLibros.Size = new System.Drawing.Size(70, 20);
            this.txtCantidadLibros.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(598, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(139, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad de Libros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Desde";
            // 
            // datePickHasta
            // 
            this.datePickHasta.CustomFormat = "dd/MMMM/yyyy";
            this.datePickHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickHasta.Location = new System.Drawing.Point(598, 51);
            this.datePickHasta.MaxDate = DateTime.Now;
            this.datePickHasta.Name = "datePickHasta";
            this.datePickHasta.Size = new System.Drawing.Size(139, 20);
            this.datePickHasta.TabIndex = 2;
            // 
            // datePickDesde
            // 
            this.datePickDesde.CustomFormat = "dd/MMMM/yyyy";
            this.datePickDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickDesde.Location = new System.Drawing.Point(430, 51);
            this.datePickDesde.Name = "datePickDesde";
            this.datePickDesde.Size = new System.Drawing.Size(139, 20);
            this.datePickDesde.TabIndex = 1;
            // 
            // panelResultados
            // 
            this.panelResultados.AutoScroll = true;
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Location = new System.Drawing.Point(8, 148);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(606, 257);
            this.panelResultados.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Libros";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(796, 426);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.numAgregarCopia);
            this.tabPage4.Controls.Add(this.numAgregarAnio);
            this.tabPage4.Controls.Add(this.numAgregarCodBarr);
            this.tabPage4.Controls.Add(this.numAgregarBibId);
            this.tabPage4.Controls.Add(this.btnAgregar);
            this.tabPage4.Controls.Add(this.txtAgregarFondo);
            this.tabPage4.Controls.Add(this.txtAgregarEdicion);
            this.tabPage4.Controls.Add(this.txtAgregarTitulo);
            this.tabPage4.Controls.Add(this.txtAgregarEt264);
            this.tabPage4.Controls.Add(this.txtAgregarEditorial);
            this.tabPage4.Controls.Add(this.txtAgregarAutor);
            this.tabPage4.Controls.Add(this.txtAgregarUnid);
            this.tabPage4.Controls.Add(this.txtAgregarClasEjem);
            this.tabPage4.Controls.Add(this.txtAgregarClaseEjem);
            this.tabPage4.Controls.Add(this.txtAgregarEstado);
            this.tabPage4.Controls.Add(this.txtAgregarClasBib);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(788, 400);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Agregar";
            // 
            // numAgregarCopia
            // 
            this.numAgregarCopia.Location = new System.Drawing.Point(171, 336);
            this.numAgregarCopia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAgregarCopia.Name = "numAgregarCopia";
            this.numAgregarCopia.Size = new System.Drawing.Size(227, 20);
            this.numAgregarCopia.TabIndex = 7;
            // 
            // numAgregarAnio
            // 
            this.numAgregarAnio.Location = new System.Drawing.Point(461, 285);
            this.numAgregarAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAgregarAnio.Name = "numAgregarAnio";
            this.numAgregarAnio.Size = new System.Drawing.Size(127, 20);
            this.numAgregarAnio.TabIndex = 13;
            // 
            // numAgregarCodBarr
            // 
            this.numAgregarCodBarr.Location = new System.Drawing.Point(171, 85);
            this.numAgregarCodBarr.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numAgregarCodBarr.Name = "numAgregarCodBarr";
            this.numAgregarCodBarr.Size = new System.Drawing.Size(227, 20);
            this.numAgregarCodBarr.TabIndex = 2;
            // 
            // numAgregarBibId
            // 
            this.numAgregarBibId.Location = new System.Drawing.Point(171, 34);
            this.numAgregarBibId.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numAgregarBibId.Name = "numAgregarBibId";
            this.numAgregarBibId.Size = new System.Drawing.Size(227, 20);
            this.numAgregarBibId.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(597, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAgregarFondo
            // 
            this.txtAgregarFondo.Location = new System.Drawing.Point(637, 285);
            this.txtAgregarFondo.Name = "txtAgregarFondo";
            this.txtAgregarFondo.Size = new System.Drawing.Size(115, 20);
            this.txtAgregarFondo.TabIndex = 14;
            // 
            // txtAgregarEdicion
            // 
            this.txtAgregarEdicion.Location = new System.Drawing.Point(461, 85);
            this.txtAgregarEdicion.Name = "txtAgregarEdicion";
            this.txtAgregarEdicion.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarEdicion.TabIndex = 9;
            // 
            // txtAgregarTitulo
            // 
            this.txtAgregarTitulo.Location = new System.Drawing.Point(461, 137);
            this.txtAgregarTitulo.Name = "txtAgregarTitulo";
            this.txtAgregarTitulo.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarTitulo.TabIndex = 10;
            // 
            // txtAgregarEt264
            // 
            this.txtAgregarEt264.Location = new System.Drawing.Point(461, 335);
            this.txtAgregarEt264.Name = "txtAgregarEt264";
            this.txtAgregarEt264.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarEt264.TabIndex = 15;
            // 
            // txtAgregarEditorial
            // 
            this.txtAgregarEditorial.Location = new System.Drawing.Point(461, 235);
            this.txtAgregarEditorial.Name = "txtAgregarEditorial";
            this.txtAgregarEditorial.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarEditorial.TabIndex = 12;
            // 
            // txtAgregarAutor
            // 
            this.txtAgregarAutor.Location = new System.Drawing.Point(461, 186);
            this.txtAgregarAutor.Name = "txtAgregarAutor";
            this.txtAgregarAutor.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarAutor.TabIndex = 11;
            // 
            // txtAgregarUnid
            // 
            this.txtAgregarUnid.Location = new System.Drawing.Point(461, 33);
            this.txtAgregarUnid.Name = "txtAgregarUnid";
            this.txtAgregarUnid.Size = new System.Drawing.Size(291, 20);
            this.txtAgregarUnid.TabIndex = 8;
            // 
            // txtAgregarClasEjem
            // 
            this.txtAgregarClasEjem.Location = new System.Drawing.Point(171, 137);
            this.txtAgregarClasEjem.Name = "txtAgregarClasEjem";
            this.txtAgregarClasEjem.Size = new System.Drawing.Size(227, 20);
            this.txtAgregarClasEjem.TabIndex = 3;
            // 
            // txtAgregarClaseEjem
            // 
            this.txtAgregarClaseEjem.Location = new System.Drawing.Point(171, 235);
            this.txtAgregarClaseEjem.Name = "txtAgregarClaseEjem";
            this.txtAgregarClaseEjem.Size = new System.Drawing.Size(227, 20);
            this.txtAgregarClaseEjem.TabIndex = 5;
            // 
            // txtAgregarEstado
            // 
            this.txtAgregarEstado.Location = new System.Drawing.Point(171, 285);
            this.txtAgregarEstado.Name = "txtAgregarEstado";
            this.txtAgregarEstado.Size = new System.Drawing.Size(227, 20);
            this.txtAgregarEstado.TabIndex = 6;
            // 
            // txtAgregarClasBib
            // 
            this.txtAgregarClasBib.Location = new System.Drawing.Point(171, 185);
            this.txtAgregarClasBib.Name = "txtAgregarClasBib";
            this.txtAgregarClasBib.Size = new System.Drawing.Size(227, 20);
            this.txtAgregarClasBib.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(404, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Edición";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 238);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Clase Ejemplar";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 288);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Estado";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Clasificación Bibliografico";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(404, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Título";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(404, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Autor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(404, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Editorial";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(404, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Año";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Copia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Et264";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Unidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "BibId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Clasificación Ejemplar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Codigo de Barras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fondo";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage5.Controls.Add(this.txtLibrosEncontrados);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.btnBuscar);
            this.tabPage5.Controls.Add(this.txtBuscarTitulo);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.panelConsultaLib);
            this.tabPage5.Controls.Add(this.btnEliminar);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.numEliminarCodBarr);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(788, 400);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Consulta y Eliminado";
            // 
            // txtLibrosEncontrados
            // 
            this.txtLibrosEncontrados.Enabled = false;
            this.txtLibrosEncontrados.Location = new System.Drawing.Point(685, 110);
            this.txtLibrosEncontrados.Name = "txtLibrosEncontrados";
            this.txtLibrosEncontrados.Size = new System.Drawing.Size(70, 20);
            this.txtLibrosEncontrados.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(581, 113);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "Libros Encontrados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(434, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Location = new System.Drawing.Point(72, 110);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarTitulo.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 113);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Título";
            // 
            // panelConsultaLib
            // 
            this.panelConsultaLib.AutoScroll = true;
            this.panelConsultaLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsultaLib.Location = new System.Drawing.Point(11, 145);
            this.panelConsultaLib.Name = "panelConsultaLib";
            this.panelConsultaLib.Size = new System.Drawing.Size(765, 236);
            this.panelConsultaLib.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(315, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(177, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "Eliminar Libro";
            // 
            // numEliminarCodBarr
            // 
            this.numEliminarCodBarr.Location = new System.Drawing.Point(123, 29);
            this.numEliminarCodBarr.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numEliminarCodBarr.Name = "numEliminarCodBarr";
            this.numEliminarCodBarr.Size = new System.Drawing.Size(177, 20);
            this.numEliminarCodBarr.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Codigo de Barras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Administrador de Acervo ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarCopia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarCodBarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregarBibId)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEliminarCodBarr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMensajeRegistro;
        private System.Windows.Forms.TextBox txtCantidadLibros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickHasta;
        private System.Windows.Forms.DateTimePicker datePickDesde;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtAgregarFondo;
        private System.Windows.Forms.TextBox txtAgregarEdicion;
        private System.Windows.Forms.TextBox txtAgregarTitulo;
        private System.Windows.Forms.TextBox txtAgregarEt264;
        private System.Windows.Forms.TextBox txtAgregarEditorial;
        private System.Windows.Forms.TextBox txtAgregarAutor;
        private System.Windows.Forms.TextBox txtAgregarUnid;
        private System.Windows.Forms.TextBox txtAgregarClasEjem;
        private System.Windows.Forms.TextBox txtAgregarClaseEjem;
        private System.Windows.Forms.TextBox txtAgregarEstado;
        private System.Windows.Forms.TextBox txtAgregarClasBib;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numAgregarCodBarr;
        private System.Windows.Forms.NumericUpDown numAgregarBibId;
        private System.Windows.Forms.NumericUpDown numAgregarAnio;
        private System.Windows.Forms.NumericUpDown numAgregarCopia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numEliminarCodBarr;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelConsultaLib;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtLibrosEncontrados;
        private System.Windows.Forms.Label label27;
    }
}

