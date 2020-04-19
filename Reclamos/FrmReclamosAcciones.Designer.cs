namespace Reclamos
{
    partial class FrmReclamosAcciones
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
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtdesaccion = new System.Windows.Forms.TextBox();
            this.txtidaccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomreclamo = new System.Windows.Forms.TextBox();
            this.txtidreclamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numrepresenta = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Rbinac = new System.Windows.Forms.RadioButton();
            this.Rbact = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numrepresenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(244, 149);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(92, 40);
            this.btnborrar.TabIndex = 97;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(137, 149);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 40);
            this.btnmodificar.TabIndex = 96;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(458, 149);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 40);
            this.btnsalir.TabIndex = 95;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(351, 149);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 40);
            this.btncancelar.TabIndex = 94;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(30, 149);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(92, 40);
            this.btnsalvar.TabIndex = 3;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtdesaccion
            // 
            this.txtdesaccion.Enabled = false;
            this.txtdesaccion.Location = new System.Drawing.Point(185, 46);
            this.txtdesaccion.Name = "txtdesaccion";
            this.txtdesaccion.Size = new System.Drawing.Size(362, 20);
            this.txtdesaccion.TabIndex = 103;
            this.txtdesaccion.TabStop = false;
            // 
            // txtidaccion
            // 
            this.txtidaccion.Location = new System.Drawing.Point(121, 46);
            this.txtidaccion.Name = "txtidaccion";
            this.txtidaccion.Size = new System.Drawing.Size(58, 20);
            this.txtidaccion.TabIndex = 1;
            this.txtidaccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidaccion_KeyDown);
            this.txtidaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidaccion_KeyPress);
            this.txtidaccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtidaccion_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(30, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "[F5]-Accion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnomreclamo
            // 
            this.txtnomreclamo.Enabled = false;
            this.txtnomreclamo.Location = new System.Drawing.Point(185, 12);
            this.txtnomreclamo.Name = "txtnomreclamo";
            this.txtnomreclamo.Size = new System.Drawing.Size(362, 20);
            this.txtnomreclamo.TabIndex = 101;
            this.txtnomreclamo.TabStop = false;
            // 
            // txtidreclamo
            // 
            this.txtidreclamo.Location = new System.Drawing.Point(121, 12);
            this.txtidreclamo.Name = "txtidreclamo";
            this.txtidreclamo.Size = new System.Drawing.Size(58, 20);
            this.txtidreclamo.TabIndex = 0;
            this.txtidreclamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidreclamo_KeyPress);
            this.txtidreclamo.Validating += new System.ComponentModel.CancelEventHandler(this.txtidreclamo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "[F5]-Reclamo\r\n";
            // 
            // numrepresenta
            // 
            this.numrepresenta.Location = new System.Drawing.Point(121, 79);
            this.numrepresenta.Name = "numrepresenta";
            this.numrepresenta.Size = new System.Drawing.Size(39, 20);
            this.numrepresenta.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 105;
            this.label10.Text = "Representa";
            // 
            // Rbinac
            // 
            this.Rbinac.AutoSize = true;
            this.Rbinac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbinac.Location = new System.Drawing.Point(207, 111);
            this.Rbinac.Name = "Rbinac";
            this.Rbinac.Size = new System.Drawing.Size(67, 18);
            this.Rbinac.TabIndex = 108;
            this.Rbinac.Text = "Inactivo";
            this.Rbinac.UseVisualStyleBackColor = true;
            // 
            // Rbact
            // 
            this.Rbact.AutoSize = true;
            this.Rbact.Checked = true;
            this.Rbact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbact.Location = new System.Drawing.Point(121, 111);
            this.Rbact.Name = "Rbact";
            this.Rbact.Size = new System.Drawing.Size(59, 18);
            this.Rbact.TabIndex = 107;
            this.Rbact.TabStop = true;
            this.Rbact.Text = "Activo";
            this.Rbact.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoRe,
            this.NombreAc,
            this.CodigoAc,
            this.NombreRe});
            this.dataGridView1.Location = new System.Drawing.Point(19, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 187);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // CodigoRe
            // 
            this.CodigoRe.HeaderText = "";
            this.CodigoRe.Name = "CodigoRe";
            this.CodigoRe.ReadOnly = true;
            this.CodigoRe.Width = 40;
            // 
            // NombreAc
            // 
            this.NombreAc.HeaderText = "Reclamos";
            this.NombreAc.Name = "NombreAc";
            this.NombreAc.ReadOnly = true;
            this.NombreAc.Width = 215;
            // 
            // CodigoAc
            // 
            this.CodigoAc.HeaderText = "";
            this.CodigoAc.Name = "CodigoAc";
            this.CodigoAc.ReadOnly = true;
            this.CodigoAc.Width = 40;
            // 
            // NombreRe
            // 
            this.NombreRe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreRe.HeaderText = "Acciones";
            this.NombreRe.Name = "NombreRe";
            this.NombreRe.ReadOnly = true;
            // 
            // FrmReclamosAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Rbinac);
            this.Controls.Add(this.Rbact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numrepresenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdesaccion);
            this.Controls.Add(this.txtidaccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnomreclamo);
            this.Controls.Add(this.txtidreclamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Name = "FrmReclamosAcciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar acciones de los tipos de reclamos";
            ((System.ComponentModel.ISupportInitialize)(this.numrepresenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtdesaccion;
        private System.Windows.Forms.TextBox txtidaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomreclamo;
        private System.Windows.Forms.TextBox txtidreclamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numrepresenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Rbinac;
        private System.Windows.Forms.RadioButton Rbact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRe;
    }
}