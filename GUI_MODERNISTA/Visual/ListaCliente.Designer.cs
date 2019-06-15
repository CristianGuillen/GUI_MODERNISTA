namespace GUI_MODERNISTA.Visual
{
    partial class ListaCliente
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarSobreCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.btnVerHistorico = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listClientes);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 254);
            this.groupBox2.TabIndex = 190;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitaciones en registro:";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 16;
            this.listClientes.Location = new System.Drawing.Point(8, 20);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(781, 228);
            this.listClientes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarSobreCliente);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.dtpFechaLlegada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(24, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 63);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar cliente";
            // 
            // txtBuscarSobreCliente
            // 
            this.txtBuscarSobreCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarSobreCliente.Location = new System.Drawing.Point(8, 26);
            this.txtBuscarSobreCliente.Name = "txtBuscarSobreCliente";
            this.txtBuscarSobreCliente.Size = new System.Drawing.Size(214, 20);
            this.txtBuscarSobreCliente.TabIndex = 182;
            this.txtBuscarSobreCliente.Text = "Información cliente";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(603, 26);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Location = new System.Drawing.Point(329, 26);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(186, 20);
            this.dtpFechaLlegada.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(245, 25);
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
            this.label8.Location = new System.Drawing.Point(536, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "Salida:";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Location = new System.Drawing.Point(219, 104);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(175, 20);
            this.txtSegundoNombre.TabIndex = 188;
            // 
            // btnVerHistorico
            // 
            this.btnVerHistorico.AutoSize = true;
            this.btnVerHistorico.BackColor = System.Drawing.Color.Silver;
            this.btnVerHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVerHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerHistorico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerHistorico.Location = new System.Drawing.Point(683, 409);
            this.btnVerHistorico.Name = "btnVerHistorico";
            this.btnVerHistorico.Size = new System.Drawing.Size(106, 23);
            this.btnVerHistorico.TabIndex = 184;
            this.btnVerHistorico.Text = "Ver histórico";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(42, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(256, 32);
            this.label17.TabIndex = 186;
            this.label17.Text = "Listado de clientes";
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.btnVerHistorico);
            this.Controls.Add(this.label17);
            this.Name = "ListaCliente";
            this.Size = new System.Drawing.Size(847, 455);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarSobreCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label btnVerHistorico;
        private System.Windows.Forms.Label label17;
    }
}
