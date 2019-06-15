namespace GUI_MODERNISTA.Visual
{
    partial class NuevaReservacion
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevoHuesped = new System.Windows.Forms.Label();
            this.lblHuespedEncontrado = new System.Windows.Forms.Label();
            this.txtBuscarCoincidencias = new System.Windows.Forms.TextBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.nudCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadNinos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtTotalNoche = new System.Windows.Forms.TextBox();
            this.panelContenedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.Controls.Add(this.txtTotalNoche);
            this.panelContenedor.Controls.Add(this.txtComentario);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label11);
            this.panelContenedor.Controls.Add(this.cmbCanal);
            this.panelContenedor.Controls.Add(this.label19);
            this.panelContenedor.Controls.Add(this.pictureBox7);
            this.panelContenedor.Controls.Add(this.groupBox2);
            this.panelContenedor.Controls.Add(this.groupBox1);
            this.panelContenedor.Controls.Add(this.label17);
            this.panelContenedor.Controls.Add(this.lbl);
            this.panelContenedor.Controls.Add(this.label10);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(760, 453);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(373, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "Cancelar";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(540, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "Guardar";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnNuevoHuesped);
            this.groupBox2.Controls.Add(this.lblHuespedEncontrado);
            this.groupBox2.Controls.Add(this.txtBuscarCoincidencias);
            this.groupBox2.Controls.Add(this.cbxTipoDocumento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(396, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 203);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Huésped:";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnNuevoHuesped
            // 
            this.btnNuevoHuesped.AutoSize = true;
            this.btnNuevoHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoHuesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNuevoHuesped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoHuesped.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoHuesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoHuesped.Location = new System.Drawing.Point(112, 156);
            this.btnNuevoHuesped.Name = "btnNuevoHuesped";
            this.btnNuevoHuesped.Size = new System.Drawing.Size(136, 23);
            this.btnNuevoHuesped.TabIndex = 86;
            this.btnNuevoHuesped.Text = "Nuevo huésped";
            // 
            // lblHuespedEncontrado
            // 
            this.lblHuespedEncontrado.AutoSize = true;
            this.lblHuespedEncontrado.Location = new System.Drawing.Point(46, 118);
            this.lblHuespedEncontrado.Name = "lblHuespedEncontrado";
            this.lblHuespedEncontrado.Size = new System.Drawing.Size(108, 13);
            this.lblHuespedEncontrado.TabIndex = 61;
            this.lblHuespedEncontrado.Text = "Huésped Encontrado";
            // 
            // txtBuscarCoincidencias
            // 
            this.txtBuscarCoincidencias.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCoincidencias.Location = new System.Drawing.Point(20, 51);
            this.txtBuscarCoincidencias.Name = "txtBuscarCoincidencias";
            this.txtBuscarCoincidencias.Size = new System.Drawing.Size(281, 20);
            this.txtBuscarCoincidencias.TabIndex = 60;
            this.txtBuscarCoincidencias.Text = "Buscar coincidencias";
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(149, 24);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(174, 21);
            this.cbxTipoDocumento.TabIndex = 59;
            this.cbxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CbxTipoDocumento_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(16, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Huésped:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCantidadNinos);
            this.groupBox1.Controls.Add(this.nudCantidadAdultos);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.dtpFechaLlegada);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(24, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 80);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cmbCanal
            // 
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(100, 165);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(151, 21);
            this.cmbCanal.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(32, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 21);
            this.label19.TabIndex = 67;
            this.label19.Text = "Canal:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(90, 45);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Location = new System.Drawing.Point(90, 16);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaLlegada.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(512, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 21);
            this.label16.TabIndex = 62;
            this.label16.Text = "Niños:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(341, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 21);
            this.label15.TabIndex = 61;
            this.label15.Text = "Adultos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(6, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 59;
            this.label13.Text = "Llegada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(7, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 21);
            this.label14.TabIndex = 60;
            this.label14.Text = "Salida:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(49, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(269, 32);
            this.label17.TabIndex = 71;
            this.label17.Text = "Nueva Reservación";
            this.label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(51, 347);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(139, 21);
            this.lbl.TabIndex = 56;
            this.lbl.Text = "Total por Noche:";
            this.lbl.Click += new System.EventHandler(this.Lbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(27, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "Comentario:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GUI_MODERNISTA.Properties.Resources.diskette;
            this.pictureBox7.Location = new System.Drawing.Point(511, 400);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 54;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // nudCantidadAdultos
            // 
            this.nudCantidadAdultos.Location = new System.Drawing.Point(421, 31);
            this.nudCantidadAdultos.Name = "nudCantidadAdultos";
            this.nudCantidadAdultos.Size = new System.Drawing.Size(65, 20);
            this.nudCantidadAdultos.TabIndex = 86;
            // 
            // nudCantidadNinos
            // 
            this.nudCantidadNinos.Location = new System.Drawing.Point(573, 31);
            this.nudCantidadNinos.Name = "nudCantidadNinos";
            this.nudCantidadNinos.Size = new System.Drawing.Size(65, 20);
            this.nudCantidadNinos.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(348, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 88;
            this.label1.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tipo documento:";
            // 
            // txtComentario
            // 
            this.txtComentario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtComentario.Location = new System.Drawing.Point(141, 211);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(239, 131);
            this.txtComentario.TabIndex = 90;
            // 
            // txtTotalNoche
            // 
            this.txtTotalNoche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalNoche.Location = new System.Drawing.Point(196, 348);
            this.txtTotalNoche.Multiline = true;
            this.txtTotalNoche.Name = "txtTotalNoche";
            this.txtTotalNoche.Size = new System.Drawing.Size(146, 26);
            this.txtTotalNoche.TabIndex = 91;
            // 
            // NuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Name = "NuevaReservacion";
            this.Size = new System.Drawing.Size(760, 453);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnNuevoHuesped;
        private System.Windows.Forms.Label lblHuespedEncontrado;
        private System.Windows.Forms.TextBox txtBuscarCoincidencias;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudCantidadNinos;
        private System.Windows.Forms.NumericUpDown nudCantidadAdultos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtTotalNoche;
    }
}
