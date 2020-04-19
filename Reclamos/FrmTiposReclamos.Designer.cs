namespace Reclamos
{
    partial class FrmTiposReclamos
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
            this.txtdesnivel = new System.Windows.Forms.TextBox();
            this.txtidnivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Rbinac = new System.Windows.Forms.RadioButton();
            this.Rbact = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesdep = new System.Windows.Forms.TextBox();
            this.txtiddep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(232, 388);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(92, 40);
            this.btnborrar.TabIndex = 57;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(126, 388);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 40);
            this.btnmodificar.TabIndex = 56;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(444, 388);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 40);
            this.btnsalir.TabIndex = 55;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(338, 388);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 40);
            this.btncancelar.TabIndex = 54;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(20, 388);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(92, 40);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtdesnivel
            // 
            this.txtdesnivel.Enabled = false;
            this.txtdesnivel.Location = new System.Drawing.Point(188, 73);
            this.txtdesnivel.Name = "txtdesnivel";
            this.txtdesnivel.Size = new System.Drawing.Size(284, 20);
            this.txtdesnivel.TabIndex = 71;
            this.txtdesnivel.TabStop = false;
            // 
            // txtidnivel
            // 
            this.txtidnivel.Location = new System.Drawing.Point(124, 73);
            this.txtidnivel.Name = "txtidnivel";
            this.txtidnivel.Size = new System.Drawing.Size(58, 20);
            this.txtidnivel.TabIndex = 2;
            this.txtidnivel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidnivel_KeyDown);
            this.txtidnivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidnivel_KeyPress);
            this.txtidnivel.Validating += new System.ComponentModel.CancelEventHandler(this.txtidnivel_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nivel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(124, 108);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(348, 20);
            this.txtdescripcion.TabIndex = 3;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(124, 12);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(58, 20);
            this.txtcod.TabIndex = 0;
            this.txtcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            this.txtcod.Validating += new System.ComponentModel.CancelEventHandler(this.txtcod_Validating);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(17, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 16);
            this.linkLabel1.TabIndex = 68;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Codigo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Rbinac
            // 
            this.Rbinac.AutoSize = true;
            this.Rbinac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbinac.Location = new System.Drawing.Point(209, 143);
            this.Rbinac.Name = "Rbinac";
            this.Rbinac.Size = new System.Drawing.Size(67, 18);
            this.Rbinac.TabIndex = 74;
            this.Rbinac.Text = "Inactivo";
            this.Rbinac.UseVisualStyleBackColor = true;
            // 
            // Rbact
            // 
            this.Rbact.AutoSize = true;
            this.Rbact.Checked = true;
            this.Rbact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbact.Location = new System.Drawing.Point(123, 143);
            this.Rbact.Name = "Rbact";
            this.Rbact.Size = new System.Drawing.Size(59, 18);
            this.Rbact.TabIndex = 73;
            this.Rbact.TabStop = true;
            this.Rbact.Text = "Activo";
            this.Rbact.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Estado";
            // 
            // txtdesdep
            // 
            this.txtdesdep.Enabled = false;
            this.txtdesdep.Location = new System.Drawing.Point(188, 43);
            this.txtdesdep.Name = "txtdesdep";
            this.txtdesdep.Size = new System.Drawing.Size(284, 20);
            this.txtdesdep.TabIndex = 77;
            this.txtdesdep.TabStop = false;
            // 
            // txtiddep
            // 
            this.txtiddep.Location = new System.Drawing.Point(124, 43);
            this.txtiddep.Name = "txtiddep";
            this.txtiddep.Size = new System.Drawing.Size(58, 20);
            this.txtiddep.TabIndex = 1;
            this.txtiddep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiddep_KeyDown);
            this.txtiddep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtiddep_KeyPress);
            this.txtiddep.Validating += new System.ComponentModel.CancelEventHandler(this.txtiddep_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Departamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnivel
            // 
            this.txtnivel.Enabled = false;
            this.txtnivel.Location = new System.Drawing.Point(478, 73);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(31, 20);
            this.txtnivel.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(23, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 192);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "S";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 30;
            // 
            // FrmTiposReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(558, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtdesdep);
            this.Controls.Add(this.txtiddep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rbinac);
            this.Controls.Add(this.Rbact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdesnivel);
            this.Controls.Add(this.txtidnivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTiposReclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de tipos de reclamos";
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
        private System.Windows.Forms.TextBox txtdesnivel;
        private System.Windows.Forms.TextBox txtidnivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton Rbinac;
        private System.Windows.Forms.RadioButton Rbact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesdep;
        private System.Windows.Forms.TextBox txtiddep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}