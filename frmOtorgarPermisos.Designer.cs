namespace SIReservas
{
    partial class frmOtorgarPermisos
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
            this.cmbSelectCargo = new System.Windows.Forms.ComboBox();
            this.cmbSelectTrabajador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkInformeClientes = new System.Windows.Forms.CheckBox();
            this.chkCrearUsuarios = new System.Windows.Forms.CheckBox();
            this.chkCrearHabitaciones = new System.Windows.Forms.CheckBox();
            this.chkCrearSedes = new System.Windows.Forms.CheckBox();
            this.chkCrearTurnos = new System.Windows.Forms.CheckBox();
            this.chkEliminarReserva = new System.Windows.Forms.CheckBox();
            this.chkModuloClientes = new System.Windows.Forms.CheckBox();
            this.chkModuloRecepcion = new System.Windows.Forms.CheckBox();
            this.chkModuloInformes = new System.Windows.Forms.CheckBox();
            this.chkCrearReserva = new System.Windows.Forms.CheckBox();
            this.chkGenerarInformes = new System.Windows.Forms.CheckBox();
            this.chkCrearHuespedes = new System.Windows.Forms.CheckBox();
            this.chkReciboCaja = new System.Windows.Forms.CheckBox();
            this.chkOtorgarPermisos = new System.Windows.Forms.CheckBox();
            this.chkModuloAdministracion = new System.Windows.Forms.CheckBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.chkModuloCaja = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.chkModuloCaja);
            this.panel1.Controls.Add(this.cmbSelectCargo);
            this.panel1.Controls.Add(this.cmbSelectTrabajador);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chkInformeClientes);
            this.panel1.Controls.Add(this.chkCrearUsuarios);
            this.panel1.Controls.Add(this.chkCrearHabitaciones);
            this.panel1.Controls.Add(this.chkCrearSedes);
            this.panel1.Controls.Add(this.chkCrearTurnos);
            this.panel1.Controls.Add(this.chkEliminarReserva);
            this.panel1.Controls.Add(this.chkModuloClientes);
            this.panel1.Controls.Add(this.chkModuloRecepcion);
            this.panel1.Controls.Add(this.chkModuloInformes);
            this.panel1.Controls.Add(this.chkCrearReserva);
            this.panel1.Controls.Add(this.chkGenerarInformes);
            this.panel1.Controls.Add(this.chkCrearHuespedes);
            this.panel1.Controls.Add(this.chkReciboCaja);
            this.panel1.Controls.Add(this.chkOtorgarPermisos);
            this.panel1.Controls.Add(this.chkModuloAdministracion);
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 347);
            this.panel1.TabIndex = 0;
            // 
            // cmbSelectCargo
            // 
            this.cmbSelectCargo.FormattingEnabled = true;
            this.cmbSelectCargo.Items.AddRange(new object[] {
            "Administrador",
            "Recepcion",
            "Gerente",
            "Cajero"});
            this.cmbSelectCargo.Location = new System.Drawing.Point(313, 63);
            this.cmbSelectCargo.Name = "cmbSelectCargo";
            this.cmbSelectCargo.Size = new System.Drawing.Size(107, 23);
            this.cmbSelectCargo.TabIndex = 37;
            this.cmbSelectCargo.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCargo_SelectedIndexChanged);
            // 
            // cmbSelectTrabajador
            // 
            this.cmbSelectTrabajador.FormattingEnabled = true;
            this.cmbSelectTrabajador.Items.AddRange(new object[] {
            "ANA CAROLINA PATIÑO PLAZAS",
            "KAREN VIVIANA CORTES SILVA",
            "LUIS ENRIQUE CUACIALPU CHUCRALA"});
            this.cmbSelectTrabajador.Location = new System.Drawing.Point(192, 36);
            this.cmbSelectTrabajador.Name = "cmbSelectTrabajador";
            this.cmbSelectTrabajador.Size = new System.Drawing.Size(228, 23);
            this.cmbSelectTrabajador.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione el cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione el trabajador:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 66);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // chkInformeClientes
            // 
            this.chkInformeClientes.AutoSize = true;
            this.chkInformeClientes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInformeClientes.Location = new System.Drawing.Point(255, 177);
            this.chkInformeClientes.Name = "chkInformeClientes";
            this.chkInformeClientes.Size = new System.Drawing.Size(123, 19);
            this.chkInformeClientes.TabIndex = 14;
            this.chkInformeClientes.Text = "Informe Clientes";
            this.chkInformeClientes.UseVisualStyleBackColor = true;
            // 
            // chkCrearUsuarios
            // 
            this.chkCrearUsuarios.AutoSize = true;
            this.chkCrearUsuarios.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearUsuarios.Location = new System.Drawing.Point(43, 131);
            this.chkCrearUsuarios.Name = "chkCrearUsuarios";
            this.chkCrearUsuarios.Size = new System.Drawing.Size(115, 19);
            this.chkCrearUsuarios.TabIndex = 13;
            this.chkCrearUsuarios.Text = "Crear Usuarios";
            this.chkCrearUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkCrearHabitaciones
            // 
            this.chkCrearHabitaciones.AutoSize = true;
            this.chkCrearHabitaciones.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearHabitaciones.Location = new System.Drawing.Point(43, 200);
            this.chkCrearHabitaciones.Name = "chkCrearHabitaciones";
            this.chkCrearHabitaciones.Size = new System.Drawing.Size(139, 19);
            this.chkCrearHabitaciones.TabIndex = 12;
            this.chkCrearHabitaciones.Text = "Crear Habitaciones";
            this.chkCrearHabitaciones.UseVisualStyleBackColor = true;
            // 
            // chkCrearSedes
            // 
            this.chkCrearSedes.AutoSize = true;
            this.chkCrearSedes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearSedes.Location = new System.Drawing.Point(43, 177);
            this.chkCrearSedes.Name = "chkCrearSedes";
            this.chkCrearSedes.Size = new System.Drawing.Size(93, 19);
            this.chkCrearSedes.TabIndex = 11;
            this.chkCrearSedes.Text = "Crear Sedes";
            this.chkCrearSedes.UseVisualStyleBackColor = true;
            // 
            // chkCrearTurnos
            // 
            this.chkCrearTurnos.AutoSize = true;
            this.chkCrearTurnos.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearTurnos.Location = new System.Drawing.Point(43, 154);
            this.chkCrearTurnos.Name = "chkCrearTurnos";
            this.chkCrearTurnos.Size = new System.Drawing.Size(104, 19);
            this.chkCrearTurnos.TabIndex = 10;
            this.chkCrearTurnos.Text = "Crear Turnos";
            this.chkCrearTurnos.UseVisualStyleBackColor = true;
            // 
            // chkEliminarReserva
            // 
            this.chkEliminarReserva.AutoSize = true;
            this.chkEliminarReserva.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarReserva.Location = new System.Drawing.Point(43, 315);
            this.chkEliminarReserva.Name = "chkEliminarReserva";
            this.chkEliminarReserva.Size = new System.Drawing.Size(130, 19);
            this.chkEliminarReserva.TabIndex = 9;
            this.chkEliminarReserva.Text = "Eliminar Reserva";
            this.chkEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // chkModuloClientes
            // 
            this.chkModuloClientes.AutoSize = true;
            this.chkModuloClientes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModuloClientes.Location = new System.Drawing.Point(239, 154);
            this.chkModuloClientes.Name = "chkModuloClientes";
            this.chkModuloClientes.Size = new System.Drawing.Size(120, 19);
            this.chkModuloClientes.TabIndex = 8;
            this.chkModuloClientes.Text = "Modulo Clientes";
            this.chkModuloClientes.UseVisualStyleBackColor = true;
            // 
            // chkModuloRecepcion
            // 
            this.chkModuloRecepcion.AutoSize = true;
            this.chkModuloRecepcion.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModuloRecepcion.Location = new System.Drawing.Point(16, 246);
            this.chkModuloRecepcion.Name = "chkModuloRecepcion";
            this.chkModuloRecepcion.Size = new System.Drawing.Size(133, 19);
            this.chkModuloRecepcion.TabIndex = 7;
            this.chkModuloRecepcion.Text = "Modulo Recepción";
            this.chkModuloRecepcion.UseVisualStyleBackColor = true;
            // 
            // chkModuloInformes
            // 
            this.chkModuloInformes.AutoSize = true;
            this.chkModuloInformes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModuloInformes.Location = new System.Drawing.Point(239, 200);
            this.chkModuloInformes.Name = "chkModuloInformes";
            this.chkModuloInformes.Size = new System.Drawing.Size(126, 19);
            this.chkModuloInformes.TabIndex = 6;
            this.chkModuloInformes.Text = "Modulo Informes";
            this.chkModuloInformes.UseVisualStyleBackColor = true;
            // 
            // chkCrearReserva
            // 
            this.chkCrearReserva.AutoSize = true;
            this.chkCrearReserva.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearReserva.Location = new System.Drawing.Point(43, 292);
            this.chkCrearReserva.Name = "chkCrearReserva";
            this.chkCrearReserva.Size = new System.Drawing.Size(111, 19);
            this.chkCrearReserva.TabIndex = 5;
            this.chkCrearReserva.Text = "Crear Reserva";
            this.chkCrearReserva.UseVisualStyleBackColor = true;
            // 
            // chkGenerarInformes
            // 
            this.chkGenerarInformes.AutoSize = true;
            this.chkGenerarInformes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerarInformes.Location = new System.Drawing.Point(251, 223);
            this.chkGenerarInformes.Name = "chkGenerarInformes";
            this.chkGenerarInformes.Size = new System.Drawing.Size(129, 19);
            this.chkGenerarInformes.TabIndex = 4;
            this.chkGenerarInformes.Text = "Generar Informes";
            this.chkGenerarInformes.UseVisualStyleBackColor = true;
            // 
            // chkCrearHuespedes
            // 
            this.chkCrearHuespedes.AutoSize = true;
            this.chkCrearHuespedes.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrearHuespedes.Location = new System.Drawing.Point(43, 269);
            this.chkCrearHuespedes.Name = "chkCrearHuespedes";
            this.chkCrearHuespedes.Size = new System.Drawing.Size(113, 19);
            this.chkCrearHuespedes.TabIndex = 3;
            this.chkCrearHuespedes.Text = "Crear Huesped";
            this.chkCrearHuespedes.UseVisualStyleBackColor = true;
            // 
            // chkReciboCaja
            // 
            this.chkReciboCaja.AutoSize = true;
            this.chkReciboCaja.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReciboCaja.Location = new System.Drawing.Point(255, 131);
            this.chkReciboCaja.Name = "chkReciboCaja";
            this.chkReciboCaja.Size = new System.Drawing.Size(112, 19);
            this.chkReciboCaja.TabIndex = 2;
            this.chkReciboCaja.Text = "Recibo de Caja";
            this.chkReciboCaja.UseVisualStyleBackColor = true;
            // 
            // chkOtorgarPermisos
            // 
            this.chkOtorgarPermisos.AutoSize = true;
            this.chkOtorgarPermisos.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtorgarPermisos.Location = new System.Drawing.Point(43, 223);
            this.chkOtorgarPermisos.Name = "chkOtorgarPermisos";
            this.chkOtorgarPermisos.Size = new System.Drawing.Size(127, 19);
            this.chkOtorgarPermisos.TabIndex = 1;
            this.chkOtorgarPermisos.Text = "Otorgar Permisos";
            this.chkOtorgarPermisos.UseVisualStyleBackColor = true;
            // 
            // chkModuloAdministracion
            // 
            this.chkModuloAdministracion.AutoSize = true;
            this.chkModuloAdministracion.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModuloAdministracion.Location = new System.Drawing.Point(16, 108);
            this.chkModuloAdministracion.Name = "chkModuloAdministracion";
            this.chkModuloAdministracion.Size = new System.Drawing.Size(166, 19);
            this.chkModuloAdministracion.TabIndex = 0;
            this.chkModuloAdministracion.Text = "Modulo Administración";
            this.chkModuloAdministracion.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarCambios.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(204, 396);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(86, 41);
            this.btnGuardarCambios.TabIndex = 38;
            this.btnGuardarCambios.Text = "Guardar Cambios!";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // chkModuloCaja
            // 
            this.chkModuloCaja.AutoSize = true;
            this.chkModuloCaja.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModuloCaja.Location = new System.Drawing.Point(239, 108);
            this.chkModuloCaja.Name = "chkModuloCaja";
            this.chkModuloCaja.Size = new System.Drawing.Size(100, 19);
            this.chkModuloCaja.TabIndex = 38;
            this.chkModuloCaja.Text = "Modulo Caja";
            this.chkModuloCaja.UseVisualStyleBackColor = true;
            // 
            // frmOtorgarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(522, 461);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOtorgarPermisos";
            this.Text = "Otorgar Permisos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkInformeClientes;
        private System.Windows.Forms.CheckBox chkCrearUsuarios;
        private System.Windows.Forms.CheckBox chkCrearHabitaciones;
        private System.Windows.Forms.CheckBox chkCrearSedes;
        private System.Windows.Forms.CheckBox chkCrearTurnos;
        private System.Windows.Forms.CheckBox chkEliminarReserva;
        private System.Windows.Forms.CheckBox chkModuloClientes;
        private System.Windows.Forms.CheckBox chkModuloRecepcion;
        private System.Windows.Forms.CheckBox chkModuloInformes;
        private System.Windows.Forms.CheckBox chkCrearReserva;
        private System.Windows.Forms.CheckBox chkGenerarInformes;
        private System.Windows.Forms.CheckBox chkCrearHuespedes;
        private System.Windows.Forms.CheckBox chkReciboCaja;
        private System.Windows.Forms.CheckBox chkOtorgarPermisos;
        private System.Windows.Forms.CheckBox chkModuloAdministracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectCargo;
        private System.Windows.Forms.ComboBox cmbSelectTrabajador;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.CheckBox chkModuloCaja;
    }
}