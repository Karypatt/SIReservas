﻿namespace SIReservas
{
    partial class frmCrearReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipoDocHuesped = new System.Windows.Forms.ComboBox();
            this.cmbCiudadHuesped = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkConvenioNo = new System.Windows.Forms.CheckBox();
            this.chkConvenioSi = new System.Windows.Forms.CheckBox();
            this.txtTelefonoHuesped = new System.Windows.Forms.TextBox();
            this.txtCorreoHuesped = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion3 = new System.Windows.Forms.TextBox();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.txtDireccion1 = new System.Windows.Forms.TextBox();
            this.cmbDirección1 = new System.Windows.Forms.ComboBox();
            this.txtIdentificacionHuesped = new System.Windows.Forms.TextBox();
            this.txtNombreHuesped = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsecutivoReserva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dTpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dTpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbTipohabitacion = new System.Windows.Forms.ComboBox();
            this.cmbNumerohabitacion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.btnBorrarRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmbTipohabitacion);
            this.panel1.Controls.Add(this.cmbNumerohabitacion);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dTpFechaRetiro);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dTpFechaIngreso);
            this.panel1.Controls.Add(this.txtConsecutivoReserva);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbTipoDocHuesped);
            this.panel1.Controls.Add(this.cmbCiudadHuesped);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTelefonoHuesped);
            this.panel1.Controls.Add(this.txtCorreoHuesped);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtDireccion3);
            this.panel1.Controls.Add(this.txtDireccion2);
            this.panel1.Controls.Add(this.txtDireccion1);
            this.panel1.Controls.Add(this.cmbDirección1);
            this.panel1.Controls.Add(this.txtIdentificacionHuesped);
            this.panel1.Controls.Add(this.txtNombreHuesped);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 368);
            this.panel1.TabIndex = 0;
            // 
            // cmbTipoDocHuesped
            // 
            this.cmbTipoDocHuesped.FormattingEnabled = true;
            this.cmbTipoDocHuesped.Items.AddRange(new object[] {
            "C.C.",
            "T.I.",
            "C.E.",
            "NIT."});
            this.cmbTipoDocHuesped.Location = new System.Drawing.Point(131, 79);
            this.cmbTipoDocHuesped.Name = "cmbTipoDocHuesped";
            this.cmbTipoDocHuesped.Size = new System.Drawing.Size(57, 21);
            this.cmbTipoDocHuesped.TabIndex = 57;
            // 
            // cmbCiudadHuesped
            // 
            this.cmbCiudadHuesped.FormattingEnabled = true;
            this.cmbCiudadHuesped.Items.AddRange(new object[] {
            "Arauca",
            "Armenia",
            "Barranquilla",
            "Bogotá",
            "Bucaramanga",
            "Cali",
            "Cartagena",
            "Cucuta",
            "Florencia",
            "Ibague",
            "Inirida",
            "Leticia",
            "Manizales",
            "Medellin",
            "Mitu",
            "Mocoa",
            "Monteria",
            "Neiva",
            "Pasto",
            "Pereira",
            "Popayan",
            "Puerto Carreño",
            "Quibdo",
            "Rioacha",
            "San Andrés",
            "San Jose del Guaviare",
            "Santa Marta",
            "Sincelejo",
            "Tunja",
            "Valledupar",
            "Villavicencio",
            "Yopal"});
            this.cmbCiudadHuesped.Location = new System.Drawing.Point(313, 228);
            this.cmbCiudadHuesped.Name = "cmbCiudadHuesped";
            this.cmbCiudadHuesped.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadHuesped.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkConvenioNo);
            this.panel2.Controls.Add(this.chkConvenioSi);
            this.panel2.Location = new System.Drawing.Point(131, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 58);
            this.panel2.TabIndex = 55;
            // 
            // chkConvenioNo
            // 
            this.chkConvenioNo.AutoSize = true;
            this.chkConvenioNo.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConvenioNo.Location = new System.Drawing.Point(4, 27);
            this.chkConvenioNo.Name = "chkConvenioNo";
            this.chkConvenioNo.Size = new System.Drawing.Size(46, 19);
            this.chkConvenioNo.TabIndex = 1;
            this.chkConvenioNo.Text = "NO";
            this.chkConvenioNo.UseVisualStyleBackColor = true;
            // 
            // chkConvenioSi
            // 
            this.chkConvenioSi.AutoSize = true;
            this.chkConvenioSi.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConvenioSi.Location = new System.Drawing.Point(4, 4);
            this.chkConvenioSi.Name = "chkConvenioSi";
            this.chkConvenioSi.Size = new System.Drawing.Size(37, 19);
            this.chkConvenioSi.TabIndex = 0;
            this.chkConvenioSi.Text = "SI";
            this.chkConvenioSi.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoHuesped
            // 
            this.txtTelefonoHuesped.Location = new System.Drawing.Point(131, 202);
            this.txtTelefonoHuesped.Name = "txtTelefonoHuesped";
            this.txtTelefonoHuesped.Size = new System.Drawing.Size(123, 20);
            this.txtTelefonoHuesped.TabIndex = 54;
            // 
            // txtCorreoHuesped
            // 
            this.txtCorreoHuesped.Location = new System.Drawing.Point(131, 177);
            this.txtCorreoHuesped.Name = "txtCorreoHuesped";
            this.txtCorreoHuesped.Size = new System.Drawing.Size(357, 20);
            this.txtCorreoHuesped.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(289, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(232, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "#";
            // 
            // txtDireccion3
            // 
            this.txtDireccion3.Location = new System.Drawing.Point(305, 153);
            this.txtDireccion3.Name = "txtDireccion3";
            this.txtDireccion3.Size = new System.Drawing.Size(40, 20);
            this.txtDireccion3.TabIndex = 50;
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Location = new System.Drawing.Point(250, 151);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.Size = new System.Drawing.Size(33, 20);
            this.txtDireccion2.TabIndex = 49;
            // 
            // txtDireccion1
            // 
            this.txtDireccion1.Location = new System.Drawing.Point(182, 150);
            this.txtDireccion1.Name = "txtDireccion1";
            this.txtDireccion1.Size = new System.Drawing.Size(45, 20);
            this.txtDireccion1.TabIndex = 48;
            // 
            // cmbDirección1
            // 
            this.cmbDirección1.FormattingEnabled = true;
            this.cmbDirección1.Items.AddRange(new object[] {
            "Cll.",
            "Cra.",
            "Av.",
            "Diag.",
            "Trans."});
            this.cmbDirección1.Location = new System.Drawing.Point(131, 150);
            this.cmbDirección1.Name = "cmbDirección1";
            this.cmbDirección1.Size = new System.Drawing.Size(45, 21);
            this.cmbDirección1.TabIndex = 47;
            // 
            // txtIdentificacionHuesped
            // 
            this.txtIdentificacionHuesped.Location = new System.Drawing.Point(131, 102);
            this.txtIdentificacionHuesped.Name = "txtIdentificacionHuesped";
            this.txtIdentificacionHuesped.Size = new System.Drawing.Size(123, 20);
            this.txtIdentificacionHuesped.TabIndex = 46;
            // 
            // txtNombreHuesped
            // 
            this.txtNombreHuesped.Location = new System.Drawing.Point(154, 125);
            this.txtNombreHuesped.Name = "txtNombreHuesped";
            this.txtNombreHuesped.Size = new System.Drawing.Size(334, 20);
            this.txtNombreHuesped.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Convenio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre/Razón Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo de documento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Reserva No.";
            // 
            // txtConsecutivoReserva
            // 
            this.txtConsecutivoReserva.Location = new System.Drawing.Point(101, 35);
            this.txtConsecutivoReserva.Name = "txtConsecutivoReserva";
            this.txtConsecutivoReserva.Size = new System.Drawing.Size(57, 20);
            this.txtConsecutivoReserva.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 63;
            this.label10.Text = "Fecha de Retiro:";
            // 
            // dTpFechaRetiro
            // 
            this.dTpFechaRetiro.Location = new System.Drawing.Point(295, 40);
            this.dTpFechaRetiro.Name = "dTpFechaRetiro";
            this.dTpFechaRetiro.Size = new System.Drawing.Size(200, 20);
            this.dTpFechaRetiro.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 15);
            this.label13.TabIndex = 61;
            this.label13.Text = "Fecha de Ingreso:";
            // 
            // dTpFechaIngreso
            // 
            this.dTpFechaIngreso.Location = new System.Drawing.Point(295, 14);
            this.dTpFechaIngreso.Name = "dTpFechaIngreso";
            this.dTpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dTpFechaIngreso.TabIndex = 60;
            // 
            // cmbTipohabitacion
            // 
            this.cmbTipohabitacion.FormattingEnabled = true;
            this.cmbTipohabitacion.Items.AddRange(new object[] {
            "Apartamento",
            "Jacuzzi",
            "Sencilla 2 camas",
            "Sencilla 3 camas"});
            this.cmbTipohabitacion.Location = new System.Drawing.Point(166, 321);
            this.cmbTipohabitacion.Name = "cmbTipohabitacion";
            this.cmbTipohabitacion.Size = new System.Drawing.Size(52, 21);
            this.cmbTipohabitacion.TabIndex = 67;
            // 
            // cmbNumerohabitacion
            // 
            this.cmbNumerohabitacion.FormattingEnabled = true;
            this.cmbNumerohabitacion.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "201",
            "202",
            "203",
            "204",
            "301",
            "302",
            "303",
            "304"});
            this.cmbNumerohabitacion.Location = new System.Drawing.Point(166, 296);
            this.cmbNumerohabitacion.Name = "cmbNumerohabitacion";
            this.cmbNumerohabitacion.Size = new System.Drawing.Size(52, 21);
            this.cmbNumerohabitacion.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 65;
            this.label14.Text = "Tipo de habitación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 64;
            this.label15.Text = "Número de habitación:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(232, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 68;
            this.label16.Text = "Dias de Reserva:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(232, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 15);
            this.label17.TabIndex = 69;
            this.label17.Text = "Número de personas:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(367, 294);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 70;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(367, 319);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 71;
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearReserva.BackColor = System.Drawing.Color.Lime;
            this.btnCrearReserva.Location = new System.Drawing.Point(365, 402);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(73, 35);
            this.btnCrearReserva.TabIndex = 1;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            // 
            // btnBorrarRegistro
            // 
            this.btnBorrarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrarRegistro.Location = new System.Drawing.Point(62, 402);
            this.btnBorrarRegistro.Name = "btnBorrarRegistro";
            this.btnBorrarRegistro.Size = new System.Drawing.Size(77, 35);
            this.btnBorrarRegistro.TabIndex = 2;
            this.btnBorrarRegistro.Text = "Borrar Registro";
            this.btnBorrarRegistro.UseVisualStyleBackColor = false;
            // 
            // frmCrearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(522, 461);
            this.Controls.Add(this.btnBorrarRegistro);
            this.Controls.Add(this.btnCrearReserva);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearReserva";
            this.Text = "frmCrearReserva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipoDocHuesped;
        private System.Windows.Forms.ComboBox cmbCiudadHuesped;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkConvenioNo;
        private System.Windows.Forms.CheckBox chkConvenioSi;
        private System.Windows.Forms.TextBox txtTelefonoHuesped;
        private System.Windows.Forms.TextBox txtCorreoHuesped;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion3;
        private System.Windows.Forms.TextBox txtDireccion2;
        private System.Windows.Forms.TextBox txtDireccion1;
        private System.Windows.Forms.ComboBox cmbDirección1;
        private System.Windows.Forms.TextBox txtIdentificacionHuesped;
        private System.Windows.Forms.TextBox txtNombreHuesped;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsecutivoReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dTpFechaRetiro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dTpFechaIngreso;
        private System.Windows.Forms.ComboBox cmbTipohabitacion;
        private System.Windows.Forms.ComboBox cmbNumerohabitacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Button btnBorrarRegistro;
    }
}