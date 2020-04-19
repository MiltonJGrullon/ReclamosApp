namespace Reclamos
{
    partial class FrmDepartamentos
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
            this.txtcoddep = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfuncion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rbact = new System.Windows.Forms.RadioButton();
            this.Rbinac = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidencargado = new System.Windows.Forms.TextBox();
            this.txtnomencargado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idencargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(246, 437);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(92, 40);
            this.btnborrar.TabIndex = 52;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(140, 437);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 40);
            this.btnmodificar.TabIndex = 51;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(458, 437);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 40);
            this.btnsalir.TabIndex = 50;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(352, 437);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 40);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(34, 437);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(92, 40);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtcoddep
            // 
            this.txtcoddep.Location = new System.Drawing.Point(128, 12);
            this.txtcoddep.Name = "txtcoddep";
            this.txtcoddep.Size = new System.Drawing.Size(58, 20);
            this.txtcoddep.TabIndex = 0;
            this.txtcoddep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcoddep_KeyDown);
            this.txtcoddep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcoddep_KeyPress);
            this.txtcoddep.Validating += new System.ComponentModel.CancelEventHandler(this.txtcoddep_Validating);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 16);
            this.linkLabel1.TabIndex = 53;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[F5]-Codigo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(128, 47);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(348, 20);
            this.txtdescripcion.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Funcion";
            // 
            // txtfuncion
            // 
            this.txtfuncion.Location = new System.Drawing.Point(127, 112);
            this.txtfuncion.Name = "txtfuncion";
            this.txtfuncion.Size = new System.Drawing.Size(429, 71);
            this.txtfuncion.TabIndex = 3;
            this.txtfuncion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Estado";
            // 
            // Rbact
            // 
            this.Rbact.AutoSize = true;
            this.Rbact.Checked = true;
            this.Rbact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbact.Location = new System.Drawing.Point(124, 199);
            this.Rbact.Name = "Rbact";
            this.Rbact.Size = new System.Drawing.Size(59, 18);
            this.Rbact.TabIndex = 60;
            this.Rbact.TabStop = true;
            this.Rbact.Text = "Activo";
            this.Rbact.UseVisualStyleBackColor = true;
            // 
            // Rbinac
            // 
            this.Rbinac.AutoSize = true;
            this.Rbinac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbinac.Location = new System.Drawing.Point(210, 199);
            this.Rbinac.Name = "Rbinac";
            this.Rbinac.Size = new System.Drawing.Size(67, 18);
            this.Rbinac.TabIndex = 61;
            this.Rbinac.Text = "Inactivo";
            this.Rbinac.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "[F5]-Encargado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtidencargado
            // 
            this.txtidencargado.Location = new System.Drawing.Point(128, 78);
            this.txtidencargado.Name = "txtidencargado";
            this.txtidencargado.Size = new System.Drawing.Size(58, 20);
            this.txtidencargado.TabIndex = 2;
            this.txtidencargado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidencargado_KeyDown);
            this.txtidencargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidencrgado);
            this.txtidencargado.Validating += new System.ComponentModel.CancelEventHandler(this.txtidencargado_Validating);
            // 
            // txtnomencargado
            // 
            this.txtnomencargado.Enabled = false;
            this.txtnomencargado.Location = new System.Drawing.Point(192, 78);
            this.txtnomencargado.Name = "txtnomencargado";
            this.txtnomencargado.Size = new System.Drawing.Size(284, 20);
            this.txtnomencargado.TabIndex = 64;
            this.txtnomencargado.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Idencargado,
            this.Funcion,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(18, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 161);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Idencargado
            // 
            this.Idencargado.HeaderText = "Idencargado";
            this.Idencargado.Name = "Idencargado";
            this.Idencargado.ReadOnly = true;
            // 
            // Funcion
            // 
            this.Funcion.HeaderText = "Funcion";
            this.Funcion.Name = "Funcion";
            this.Funcion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(588, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnomencargado);
            this.Controls.Add(this.txtidencargado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rbinac);
            this.Controls.Add(this.Rbact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtfuncion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcoddep);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro del Departamento";
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
        private System.Windows.Forms.TextBox txtcoddep;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtfuncion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rbact;
        private System.Windows.Forms.RadioButton Rbinac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidencargado;
        private System.Windows.Forms.TextBox txtnomencargado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idencargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}