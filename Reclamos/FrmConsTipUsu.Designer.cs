namespace Reclamos
{
    partial class FrmConsTipUsu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnselec = new System.Windows.Forms.Button();
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.nota});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 213);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // Btnsalir
            // 
            this.Btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalir.Location = new System.Drawing.Point(394, 276);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(104, 32);
            this.Btnsalir.TabIndex = 186;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btnselec
            // 
            this.Btnselec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnselec.Location = new System.Drawing.Point(213, 276);
            this.Btnselec.Name = "Btnselec";
            this.Btnselec.Size = new System.Drawing.Size(104, 32);
            this.Btnselec.TabIndex = 3;
            this.Btnselec.Text = "Seleccionar";
            this.Btnselec.UseVisualStyleBackColor = true;
            this.Btnselec.Click += new System.EventHandler(this.Btnselec_Click);
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnaceptar.Location = new System.Drawing.Point(554, 11);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(104, 32);
            this.Btnaceptar.TabIndex = 1;
            this.Btnaceptar.Text = "Aceptar";
            this.Btnaceptar.UseVisualStyleBackColor = true;
            this.Btnaceptar.Click += new System.EventHandler(this.Btnaceptar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(93, 18);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(455, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 185;
            this.label1.Text = "Buscar:";
            // 
            // FrmConsTipUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(698, 318);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnselec);
            this.Controls.Add(this.Btnaceptar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmConsTipUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de tipos de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnselec;
        private System.Windows.Forms.Button Btnaceptar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
    }
}