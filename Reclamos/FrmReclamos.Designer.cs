namespace Reclamos
{
    partial class FrmReclamos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtcodcli = new System.Windows.Forms.TextBox();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.cmboperador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbreclamos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.RichTextBox();
            this.HoraA = new System.Windows.Forms.DateTimePicker();
            this.HoraD = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btnaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(80, 10);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(112, 23);
            this.txtcod.TabIndex = 1;
            this.txtcod.TabStop = false;
            this.txtcod.Text = "????????? ";
            this.txtcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(455, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(507, 12);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 3;
            this.fecha.TabStop = false;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblcliente.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblcliente.Location = new System.Drawing.Point(12, 77);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(85, 20);
            this.lblcliente.TabIndex = 4;
            this.lblcliente.Text = "[F5] - Cliente";
            this.lblcliente.Click += new System.EventHandler(this.lblcliente_Click);
            // 
            // txtcodcli
            // 
            this.txtcodcli.Location = new System.Drawing.Point(103, 79);
            this.txtcodcli.Name = "txtcodcli";
            this.txtcodcli.Size = new System.Drawing.Size(80, 20);
            this.txtcodcli.TabIndex = 0;
            this.txtcodcli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodcli_KeyDown);
            this.txtcodcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodcli_KeyPress);
            this.txtcodcli.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodcli_Validating);
            // 
            // txtnomcli
            // 
            this.txtnomcli.Enabled = false;
            this.txtnomcli.Location = new System.Drawing.Point(185, 79);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(339, 20);
            this.txtnomcli.TabIndex = 6;
            // 
            // txtdir
            // 
            this.txtdir.Enabled = false;
            this.txtdir.Location = new System.Drawing.Point(185, 105);
            this.txtdir.Multiline = true;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(339, 45);
            this.txtdir.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(185, 156);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(169, 20);
            this.txttelefono.TabIndex = 8;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Location = new System.Drawing.Point(360, 156);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(164, 20);
            this.txtcorreo.TabIndex = 9;
            // 
            // cmboperador
            // 
            this.cmboperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperador.FormattingEnabled = true;
            this.cmboperador.Location = new System.Drawing.Point(103, 191);
            this.cmboperador.Name = "cmboperador";
            this.cmboperador.Size = new System.Drawing.Size(421, 21);
            this.cmboperador.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Operador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(35, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Reclamo";
            // 
            // cmbreclamos
            // 
            this.cmbreclamos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbreclamos.FormattingEnabled = true;
            this.cmbreclamos.Location = new System.Drawing.Point(103, 229);
            this.cmbreclamos.Name = "cmbreclamos";
            this.cmbreclamos.Size = new System.Drawing.Size(421, 21);
            this.cmbreclamos.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(53, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Notas";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(103, 462);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(421, 39);
            this.txtnota.TabIndex = 5;
            this.txtnota.Text = "";
            // 
            // HoraA
            // 
            this.HoraA.Enabled = false;
            this.HoraA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraA.Location = new System.Drawing.Point(603, 102);
            this.HoraA.Name = "HoraA";
            this.HoraA.Size = new System.Drawing.Size(107, 20);
            this.HoraA.TabIndex = 18;
            this.HoraA.TabStop = false;
            // 
            // HoraD
            // 
            this.HoraD.Enabled = false;
            this.HoraD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraD.Location = new System.Drawing.Point(604, 156);
            this.HoraD.Name = "HoraD";
            this.HoraD.Size = new System.Drawing.Size(107, 20);
            this.HoraD.TabIndex = 19;
            this.HoraD.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Procedimiento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(695, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Accion
            // 
            this.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Accion.HeaderText = "Acciones";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // btnprocesar
            // 
            this.btnprocesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprocesar.Location = new System.Drawing.Point(49, 523);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(95, 32);
            this.btnprocesar.TabIndex = 6;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodificar.Location = new System.Drawing.Point(233, 523);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(95, 32);
            this.btnmodificar.TabIndex = 23;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancelar.Location = new System.Drawing.Point(429, 523);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 32);
            this.btncancelar.TabIndex = 24;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(612, 523);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 32);
            this.btnsalir.TabIndex = 25;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(608, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Hora Atendido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(599, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hora Despachado";
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaceptar.Location = new System.Drawing.Point(530, 227);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(115, 23);
            this.Btnaceptar.TabIndex = 3;
            this.Btnaceptar.Text = "Aceptar Datos";
            this.Btnaceptar.UseVisualStyleBackColor = true;
            this.Btnaceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(726, 566);
            this.Controls.Add(this.Btnaceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HoraD);
            this.Controls.Add(this.HoraA);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbreclamos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmboperador);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txtnomcli);
            this.Controls.Add(this.txtcodcli);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtcodcli;
        private System.Windows.Forms.TextBox txtnomcli;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.ComboBox cmboperador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbreclamos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtnota;
        private System.Windows.Forms.DateTimePicker HoraA;
        private System.Windows.Forms.DateTimePicker HoraD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.Button Btnaceptar;
    }
}