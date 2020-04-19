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
    public partial class FrmTiposReclamos : Form
    {
        public FrmTiposReclamos()
        {
            InitializeComponent();
            limpiar();
            Codigo.DataPropertyName = "id";
            Descripcion.DataPropertyName = "descripcion";
            Estado.DataPropertyName = "estado";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);
        }

        private void camposlec(bool vtip)
        {
            txtcod.Enabled = vtip;
            txtdescripcion.Enabled = vtip;
            txtidnivel.Enabled = vtip;
            txtiddep.Enabled = vtip; 
            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id,descripcion,estado from reclamos.Tipo_Reclamos where idcompania = " + Ctool.cia + vfil + " order by id desc");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }

        private void limpiar(bool a =true)
        {
            txtdescripcion.Text = string.Empty;
            txtiddep.Text = string.Empty;
            txtdesdep.Text = string.Empty;
            txtidnivel.Text = string.Empty;
            txtdesnivel.Text = string.Empty;
            txtnivel.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false;

            if (a)
            {
                txtcod.Text = string.Empty;
                txtcod.Focus();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            FrmConsTipReclamos frm = new FrmConsTipReclamos();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtcod.Text = Ctool.vretorno.Trim();
                llenarcampos ();
                Ctool.vretorno = String.Empty;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            buscardepa();
        }

        private void buscardepa()
        {
            FrmConsDepa frm = new FrmConsDepa();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtiddep.Text = Ctool.vretorno.Trim();
                llenardep();
                Ctool.vretorno = String.Empty;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            llenargrid();
            camposlec(true);
            limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtiddep.Focus();
        }

        private void txtiddep_Validating(object sender, CancelEventArgs e)
        {
            llenardep();
        }

        private void llenardep()
        {
            if (String.IsNullOrEmpty(txtiddep.Text.Trim()))
                return;

            DataTable dt = new DataTable();
            dt = Ctool.ExcSqlDT($"Select descripcion from Reclamos.Departamentos where idcompania = {Ctool.cia} and id = {txtiddep.Text.Trim()}");
            if (dt.Rows.Count > 0)
                txtdesdep.Text = dt.Rows[0]["descripcion"].ToString();
            else
                txtdesdep.Text = String.Empty;
        }

        private void txtidnivel_Validating(object sender, CancelEventArgs e)
        {
            llenarniveles();
        }

        private void llenarniveles()
        {
            if (String.IsNullOrEmpty(txtidnivel.Text.Trim()))
                return;

            DataTable dt = new DataTable();
            dt = Ctool.ExcSqlDT($"Select descripcion,nivel from Reclamos.Tipos_Niveles where idcompania = {Ctool.cia} and id = {txtidnivel.Text.Trim()}");
            if (dt.Rows.Count > 0)
            {
                txtdesnivel.Text = dt.Rows[0]["descripcion"].ToString();
                txtnivel.Text = dt.Rows[0]["nivel"].ToString().Trim();
            }
            else
            {
                txtdesnivel.Text = String.Empty;
                txtnivel.Text = String.Empty;
            }
        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcod.Text))
                llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from reclamos.Tipo_Reclamos where idcompania = " + Ctool.cia + " and id = " + txtcod.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtdescripcion.Text = dt.Rows[0]["descripcion"].ToString().Trim();
                txtiddep.Text = dt.Rows[0]["iddepartamento"].ToString().Trim();
                txtidnivel.Text = dt.Rows[0]["idnivel"].ToString().Trim();
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);
                llenardep();
                llenarniveles();
                camposlec(false);
                txtdescripcion.Focus();
            }
            else
            {
                camposlec(true);
                limpiar(false);
            }
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
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

        private void txtiddep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
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

        private void txtidnivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
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

        private void label3_Click(object sender, EventArgs e)
        {
            buscarnivel();
        }

        private void buscarnivel()
        {
            FrmConsNivel frm = new FrmConsNivel();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtidnivel.Text = Ctool.vretorno.Trim();
                llenarniveles();
                Ctool.vretorno = String.Empty;
            }
        }

        private void txtidnivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                buscarnivel();
        }

        private void txtiddep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                buscardepa();
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                buscar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            { 
                txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                if (!string.IsNullOrEmpty(txtcod.Text))
                    llenarcampos();
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcod.Text.Trim()))
            {
                MessageBox.Show("Campo Obligatorio, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtiddep.Text.Trim()))
            {
                MessageBox.Show("Campo Obligatorio, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtiddep.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtidnivel.Text.Trim()))
            {
                MessageBox.Show("Campo Obligatorio, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidnivel.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Campo Obligatorio, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescripcion.Focus();
                return;
            }

            if (!Ctool.valexitbl($"Reclamos.Departamentos",$" idcompania = {Ctool.cia} and id = {txtiddep.Text.Trim()}"))
            {
                MessageBox.Show("No. de departamento no existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtiddep.Focus();
                return;
            }

            if (!Ctool.valexitbl($"Reclamos.Tipos_Niveles", $" idcompania = {Ctool.cia} and id = {txtidnivel.Text.Trim()}"))
            {
                MessageBox.Show("No. de Nivel no existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidnivel.Focus();
                return;
            }

            string vex = String.Format("Exec Reclamos.Proc_Tipos_Reclamos @idcompania = {0},@id = {1},@iddepartamento = {2},@idnivel = {3},@descripcion = '{4}',@estado = {5}", Ctool.cia, txtcod.Text.Trim(), txtiddep.Text.Trim(), txtidnivel.Text.Trim(), txtdescripcion.Text.Trim(), Convert.ToInt32(Rbact.Checked));
            Ctool.ExcSql(vex);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimiento de Tipos Reclamos.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            llenargrid();
            limpiar();

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcod.Focus();
                return;
            }

            string vcod = txtcod.Text.Trim();

            DialogResult dresult = MessageBox.Show($"Esta seguro que desea borrar el id Tipo reclamo : {txtcod.Text.Trim()} ?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {
                Ctool.ExcSql($"delete from reclamos.Tipo_Reclamos  where idcompania = {Ctool.cia} and id = {vcod}");
                if (Ctool.OcError)
                {
                    MessageBox.Show("Ocurrio un error para borrar de Tipos Reclamos.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } 
            llenargrid();
            limpiar();
        }
    }
}
