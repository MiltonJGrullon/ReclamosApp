namespace Reclamos
{
    partial class FrmClientes
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
            this.txtcoddep = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rbinac = new System.Windows.Forms.RadioButton();
            this.Rbact = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtnompais = new System.Windows.Forms.TextBox();
            this.txtcodpais = new System.Windows.Forms.TextBox();
            this.txtcodprovincia = new System.Windows.Forms.TextBox();
            this.txtnomprovincia = new System.Windows.Forms.TextBox();
            this.txtcodmunicipio = new System.Windows.Forms.TextBox();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.txtcodsector = new System.Windows.Forms.TextBox();
            this.txtsector = new System.Windows.Forms.TextBox();
            this.txtcodparaje = new System.Windows.Forms.TextBox();
            this.txtparaje = new System.Windows.Forms.TextBox();
            this.txtcodcalle = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcoddep
            // 
            this.txtcoddep.Location = new System.Drawing.Point(109, 16);
            this.txtcoddep.Name = "txtcoddep";
            this.txtcoddep.Size = new System.Drawing.Size(58, 20);
            this.txtcoddep.TabIndex = 0;
            this.txtcoddep.TextChanged += new System.EventHandler(this.txtcoddep_TextChanged);
            this.txtcoddep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcoddep_KeyPress);
            this.txtcoddep.Validating += new System.ComponentModel.CancelEventHandler(this.txtcoddep_Validating);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(29, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 16);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Codigo";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(109, 86);
            this.txtapellido.MaxLength = 100;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(450, 20);
            this.txtapellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 139;
            this.label2.Text = "Apellidos";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(109, 53);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(450, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 137;
            this.label1.Text = "Nombre/s";
            // 
            // Rbinac
            // 
            this.Rbinac.AutoSize = true;
            this.Rbinac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbinac.Location = new System.Drawing.Point(197, 486);
            this.Rbinac.Name = "Rbinac";
            this.Rbinac.Size = new System.Drawing.Size(67, 18);
            this.Rbinac.TabIndex = 144;
            this.Rbinac.Text = "Inactivo";
            this.Rbinac.UseVisualStyleBackColor = true;
            // 
            // Rbact
            // 
            this.Rbact.AutoSize = true;
            this.Rbact.Checked = true;
            this.Rbact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbact.Location = new System.Drawing.Point(111, 486);
            this.Rbact.Name = "Rbact";
            this.Rbact.Size = new System.Drawing.Size(59, 18);
            this.Rbact.TabIndex = 142;
            this.Rbact.TabStop = true;
            this.Rbact.Text = "Activo";
            this.Rbact.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 143;
            this.label6.Text = "Estado";
            // 
            // txtel
            // 
            this.txtel.Location = new System.Drawing.Point(109, 125);
            this.txtel.MaxLength = 20;
            this.txtel.Name = "txtel";
            this.txtel.Size = new System.Drawing.Size(114, 20);
            this.txtel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 146;
            this.label3.Text = "Telefono";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(109, 161);
            this.txtcel.MaxLength = 20;
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(114, 20);
            this.txtcel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 148;
            this.label4.Text = "Celular";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(109, 194);
            this.txtemail.MaxLength = 60;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(335, 20);
            this.txtemail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 150;
            this.label5.Text = "Email";
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(250, 526);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(92, 40);
            this.btnborrar.TabIndex = 155;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(135, 526);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 40);
            this.btnmodificar.TabIndex = 154;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(480, 526);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 40);
            this.btnsalir.TabIndex = 153;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(365, 526);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 40);
            this.btncancelar.TabIndex = 152;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(20, 526);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(92, 40);
            this.btnsalvar.TabIndex = 13;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(29, 234);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(39, 16);
            this.linkLabel2.TabIndex = 156;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Pais";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(29, 270);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(73, 16);
            this.linkLabel3.TabIndex = 157;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Provincia";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(29, 306);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(74, 16);
            this.linkLabel4.TabIndex = 158;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Municipio";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.Location = new System.Drawing.Point(29, 342);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(53, 16);
            this.linkLabel5.TabIndex = 159;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Sector";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.Location = new System.Drawing.Point(29, 378);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(54, 16);
            this.linkLabel6.TabIndex = 160;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Paraje";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.Location = new System.Drawing.Point(29, 414);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(44, 16);
            this.linkLabel7.TabIndex = 161;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 162;
            this.label7.Text = "Direccion ";
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(108, 449);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(450, 20);
            this.txtdir.TabIndex = 12;
            // 
            // txtnompais
            // 
            this.txtnompais.Enabled = false;
            this.txtnompais.Location = new System.Drawing.Point(161, 234);
            this.txtnompais.MaxLength = 100;
            this.txtnompais.Name = "txtnompais";
            this.txtnompais.Size = new System.Drawing.Size(283, 20);
            this.txtnompais.TabIndex = 164;
            // 
            // txtcodpais
            // 
            this.txtcodpais.Location = new System.Drawing.Point(108, 234);
            this.txtcodpais.Name = "txtcodpais";
            this.txtcodpais.Size = new System.Drawing.Size(47, 20);
            this.txtcodpais.TabIndex = 6;
            this.txtcodpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodpais_KeyPress);
            this.txtcodpais.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodpais_Validating);
            // 
            // txtcodprovincia
            // 
            this.txtcodprovincia.Location = new System.Drawing.Point(108, 269);
            this.txtcodprovincia.Name = "txtcodprovincia";
            this.txtcodprovincia.Size = new System.Drawing.Size(47, 20);
            this.txtcodprovincia.TabIndex = 7;
            this.txtcodprovincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodprovincia_KeyPress);
            this.txtcodprovincia.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodprovincia_Validating);
            // 
            // txtnomprovincia
            // 
            this.txtnomprovincia.Enabled = false;
            this.txtnomprovincia.Location = new System.Drawing.Point(161, 269);
            this.txtnomprovincia.MaxLength = 100;
            this.txtnomprovincia.Name = "txtnomprovincia";
            this.txtnomprovincia.Size = new System.Drawing.Size(283, 20);
            this.txtnomprovincia.TabIndex = 166;
            // 
            // txtcodmunicipio
            // 
            this.txtcodmunicipio.Location = new System.Drawing.Point(108, 306);
            this.txtcodmunicipio.Name = "txtcodmunicipio";
            this.txtcodmunicipio.Size = new System.Drawing.Size(47, 20);
            this.txtcodmunicipio.TabIndex = 8;
            this.txtcodmunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodmunicipio_KeyPress);
            this.txtcodmunicipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodmunicipio_Validating);
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Enabled = false;
            this.txtmunicipio.Location = new System.Drawing.Point(161, 306);
            this.txtmunicipio.MaxLength = 100;
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(283, 20);
            this.txtmunicipio.TabIndex = 168;
            // 
            // txtcodsector
            // 
            this.txtcodsector.Location = new System.Drawing.Point(108, 341);
            this.txtcodsector.Name = "txtcodsector";
            this.txtcodsector.Size = new System.Drawing.Size(47, 20);
            this.txtcodsector.TabIndex = 9;
            this.txtcodsector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodsector_KeyPress);
            this.txtcodsector.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodsector_Validating);
            // 
            // txtsector
            // 
            this.txtsector.Enabled = false;
            this.txtsector.Location = new System.Drawing.Point(161, 341);
            this.txtsector.MaxLength = 100;
            this.txtsector.Name = "txtsector";
            this.txtsector.Size = new System.Drawing.Size(283, 20);
            this.txtsector.TabIndex = 170;
            // 
            // txtcodparaje
            // 
            this.txtcodparaje.Location = new System.Drawing.Point(108, 377);
            this.txtcodparaje.Name = "txtcodparaje";
            this.txtcodparaje.Size = new System.Drawing.Size(47, 20);
            this.txtcodparaje.TabIndex = 10;
            this.txtcodparaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodparaje_KeyPress);
            this.txtcodparaje.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodparaje_Validating);
            // 
            // txtparaje
            // 
            this.txtparaje.Enabled = false;
            this.txtparaje.Location = new System.Drawing.Point(161, 377);
            this.txtparaje.MaxLength = 100;
            this.txtparaje.Name = "txtparaje";
            this.txtparaje.Size = new System.Drawing.Size(283, 20);
            this.txtparaje.TabIndex = 172;
            // 
            // txtcodcalle
            // 
            this.txtcodcalle.Location = new System.Drawing.Point(108, 413);
            this.txtcodcalle.Name = "txtcodcalle";
            this.txtcodcalle.Size = new System.Drawing.Size(47, 20);
            this.txtcodcalle.TabIndex = 11;
            this.txtcodcalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodcalle_KeyPress);
            this.txtcodcalle.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodcalle_Validating);
            // 
            // txtcalle
            // 
            this.txtcalle.Enabled = false;
            this.txtcalle.Location = new System.Drawing.Point(161, 413);
            this.txtcalle.MaxLength = 100;
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(283, 20);
            this.txtcalle.TabIndex = 174;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(579, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(272, 566);
            this.dataGridView1.TabIndex = 175;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Id";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 55;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre/s | Apellido/s";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcodcalle);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtcodparaje);
            this.Controls.Add(this.txtparaje);
            this.Controls.Add(this.txtcodsector);
            this.Controls.Add(this.txtsector);
            this.Controls.Add(this.txtcodmunicipio);
            this.Controls.Add(this.txtmunicipio);
            this.Controls.Add(this.txtcodprovincia);
            this.Controls.Add(this.txtnomprovincia);
            this.Controls.Add(this.txtcodpais);
            this.Controls.Add(this.txtnompais);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rbinac);
            this.Controls.Add(this.Rbact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcoddep);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcoddep;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rbinac;
        private System.Windows.Forms.RadioButton Rbact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtnompais;
        private System.Windows.Forms.TextBox txtcodpais;
        private System.Windows.Forms.TextBox txtcodprovincia;
        private System.Windows.Forms.TextBox txtnomprovincia;
        private System.Windows.Forms.TextBox txtcodmunicipio;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.TextBox txtcodsector;
        private System.Windows.Forms.TextBox txtsector;
        private System.Windows.Forms.TextBox txtcodparaje;
        private System.Windows.Forms.TextBox txtparaje;
        private System.Windows.Forms.TextBox txtcodcalle;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}