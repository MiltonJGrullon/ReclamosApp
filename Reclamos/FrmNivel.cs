using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Reclamos
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
           
            Codigo.DataPropertyName = "id";
            Descripcion.DataPropertyName = "descripcion";
            Nivel.DataPropertyName = "nivel";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);
        }
        private void limpiar(bool a = true)
        {
            txtdescripcion.Text = string.Empty;
           

            if (a)
            {
                txtcodnivel.Text = string.Empty;
                txtcodnivel.Focus();
            }


        }
        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from reclamos.Tipos_Niveles where idcompania = " + Ctool.cia + " and id = " + txtcodnivel.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtdescripcion.Text = dt.Rows[0]["descripcion"].ToString().Trim();
                numnivel.Value=Convert.ToByte(dt.Rows[0]["nivel"].ToString().Trim());
                camposlec(false);
                txtdescripcion.Focus();
            }
            else
            {
                camposlec(true);
                limpiar(false);
            }
        }

        private void camposlec(bool vtip = true)
        {
            txtcodnivel.Enabled = vtip;
            txtdescripcion.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
            numnivel.Enabled = vtip;
        }
        DataTable dt = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dt = Ctool.ExcSqlDT("select id,descripcion,nivel from reclamos.Tipos_Niveles  where idcompania = " + Ctool.cia); 
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dt;
        }
       
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtcodnivel.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcodnivel.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Campo descripcion es obligatorio, favor revisar.");
                txtdescripcion.Focus();
                return;
            }
            string vcod = txtcodnivel.Text.Trim(), vdes = txtdescripcion.Text.Trim();
            string query =string.Format("exec insertar_tpsniveles {0},{1},'{2}',{3}",Ctool.cia,txtcodnivel.Text,txtdescripcion.Text,numnivel.Value);
            Ctool.ExcSql(query);
            if (Ctool.OcError)
            {
                return;
            }

            llenargrid();
            limpiar();

        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {
            

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodnivel.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcodnivel.Focus();
                return;
            }

            string vcod = txtcodnivel.Text.Trim();

            if (string.IsNullOrEmpty(txtcodnivel.Text.Trim()) == false)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    Ctool.ExcSql($"delete from reclamos.Tipos_Niveles  where idcompania = {Ctool.cia} and id = {vcod}");


                MessageBox.Show("Registro Borrado");
                }
                else

                {

                }
            }
           
               
           
            if (Ctool.OcError)
            {
                return;
            }
            llenargrid();
            limpiar();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            llenargrid();
            camposlec(true);
            limpiar();
        }

        private void txtcodnivel_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodnivel.Text))
                llenarcampos();
        }

       

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtdescripcion.Focus();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtcodnivel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if (!string.IsNullOrEmpty(txtcodnivel.Text))
                llenarcampos();
        }

        private void txtcodnivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscarnivel();
        }

        private void buscarnivel()
        { 
            FrmConsNivel frm = new FrmConsNivel();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtcodnivel.Text = Ctool.vretorno.Trim();
                llenarcampos();
                Ctool.vretorno = String.Empty;
            }
        }

        private void txtcodnivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                buscarnivel();
            }
        }
    }
   
}
