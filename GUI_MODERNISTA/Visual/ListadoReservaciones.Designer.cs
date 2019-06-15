namespace GUI_MODERNISTA.Visual
{
    partial class ListadoReservaciones
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.cbxEstadoHabitación = new System.Windows.Forms.ComboBox();
            this.btnBloquearHabitacion = new System.Windows.Forms.Label();
            this.btnNuevaReservación = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.nupCantidadNinos = new System.Windows.Forms.NumericUpDown();
            this.nupCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listHabitaciones = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listInformacionHuesped = new System.Windows.Forms.ListBox();
            this.btnCancelarReservacion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadAdultos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Location = new System.Drawing.Point(231, 96);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(175, 20);
            this.txtSegundoNombre.TabIndex = 165;
            // 
            // cbxEstadoHabitación
            // 
            this.cbxEstadoHabitación.FormattingEnabled = true;
            this.cbxEstadoHabitación.Location = new System.Drawing.Point(309, 132);
            this.cbxEstadoHabitación.Name = "cbxEstadoHabitación";
            this.cbxEstadoHabitación.Size = new System.Drawing.Size(197, 21);
            this.cbxEstadoHabitación.TabIndex = 148;
            this.cbxEstadoHabitación.SelectedIndexChanged += new System.EventHandler(this.CbxEstadoHabitación_SelectedIndexChanged);
            // 
            // btnBloquearHabitacion
            // 
            this.btnBloquearHabitacion.AutoSize = true;
            this.btnBloquearHabitacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBloquearHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBloquearHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBloquearHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquearHabitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloquearHabitacion.Location = new System.Drawing.Point(295, 397);
            this.btnBloquearHabitacion.Name = "btnBloquearHabitacion";
            this.btnBloquearHabitacion.Size = new System.Drawing.Size(171, 23);
            this.btnBloquearHabitacion.TabIndex = 163;
            this.btnBloquearHabitacion.Text = "Bloquear habitación";
            this.btnBloquearHabitacion.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnNuevaReservación
            // 
            this.btnNuevaReservación.AutoSize = true;
            this.btnNuevaReservación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevaReservación.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNuevaReservación.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaReservación.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReservación.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaReservación.Location = new System.Drawing.Point(664, 397);
            this.btnNuevaReservación.Name = "btnNuevaReservación";
            this.btnNuevaReservación.Size = new System.Drawing.Size(159, 23);
            this.btnNuevaReservación.TabIndex = 145;
            this.btnNuevaReservación.Text = "Nueva reservación";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(54, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 32);
            this.label17.TabIndex = 156;
            this.label17.Text = "Reservaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(129, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 21);
            this.label9.TabIndex = 141;
            this.label9.Text = "Estado habitación:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarHabitacion);
            this.groupBox1.Controls.Add(this.nupCantidadNinos);
            this.groupBox1.Controls.Add(this.nupCantidadAdultos);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.dtpFechaLlegada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(36, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 63);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar reservación";
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(8, 26);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(214, 20);
            this.txtBuscarHabitacion.TabIndex = 182;
            this.txtBuscarHabitacion.Text = "Buscar Habitación";
            // 
            // nupCantidadNinos
            // 
            this.nupCantidadNinos.Location = new System.Drawing.Point(732, 27);
            this.nupCantidadNinos.Name = "nupCantidadNinos";
            this.nupCantidadNinos.Size = new System.Drawing.Size(57, 20);
            this.nupCantidadNinos.TabIndex = 181;
            // 
            // nupCantidadAdultos
            // 
            this.nupCantidadAdultos.Location = new System.Drawing.Point(603, 27);
            this.nupCantidadAdultos.Name = "nupCantidadAdultos";
            this.nupCantidadAdultos.Size = new System.Drawing.Size(57, 20);
            this.nupCantidadAdultos.TabIndex = 180;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(328, 38);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Location = new System.Drawing.Point(329, 17);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaLlegada.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(671, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Niños:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(532, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Adultos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(245, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Llegada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(245, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "Salida:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listHabitaciones);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 213);
            this.groupBox2.TabIndex = 180;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitaciones en registro:";
            // 
            // listHabitaciones
            // 
            this.listHabitaciones.FormattingEnabled = true;
            this.listHabitaciones.ItemHeight = 16;
            this.listHabitaciones.Location = new System.Drawing.Point(8, 20);
            this.listHabitaciones.Name = "listHabitaciones";
            this.listHabitaciones.Size = new System.Drawing.Size(462, 180);
            this.listHabitaciones.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listInformacionHuesped);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(518, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 213);
            this.groupBox3.TabIndex = 181;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información huésped:";
            // 
            // listInformacionHuesped
            // 
            this.listInformacionHuesped.FormattingEnabled = true;
            this.listInformacionHuesped.ItemHeight = 16;
            this.listInformacionHuesped.Location = new System.Drawing.Point(7, 19);
            this.listInformacionHuesped.Name = "listInformacionHuesped";
            this.listInformacionHuesped.Size = new System.Drawing.Size(300, 180);
            this.listInformacionHuesped.TabIndex = 1;
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.AutoSize = true;
            this.btnCancelarReservacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarReservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelarReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReservacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarReservacion.Location = new System.Drawing.Point(477, 397);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(179, 23);
            this.btnCancelarReservacion.TabIndex = 182;
            this.btnCancelarReservacion.Text = "Cancelar reservación";
            this.btnCancelarReservacion.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ListadoReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelarReservacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.cbxEstadoHabitación);
            this.Controls.Add(this.btnBloquearHabitacion);
            this.Controls.Add(this.btnNuevaReservación);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Name = "ListadoReservaciones";
            this.Size = new System.Drawing.Size(861, 448);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadAdultos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.ComboBox cbxEstadoHabitación;
        private System.Windows.Forms.Label btnBloquearHabitacion;
        private System.Windows.Forms.Label btnNuevaReservación;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupCantidadNinos;
        private System.Windows.Forms.NumericUpDown nupCantidadAdultos;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label btnCancelarReservacion;
        private System.Windows.Forms.ListBox listHabitaciones;
        private System.Windows.Forms.ListBox listInformacionHuesped;
    }
}
