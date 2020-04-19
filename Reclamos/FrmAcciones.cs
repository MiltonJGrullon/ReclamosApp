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
    public partial class FrmAcciones : Form
    {
        public FrmAcciones()
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

        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id,descripcion,estado from reclamos.acciones where idcompania = " + Ctool.cia+vfil+" order by id desc");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
         }

        DataTable dtdata = new DataTable();
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            llenargrid();
            camposlec(true);
            limpiar();

         }

        private void limpiar(bool a = true)
        {
            txtdescripcion.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false;

            if (a)
            {
                txtcod.Text = string.Empty;
                txtcod.Focus();
            }

                
        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtcod.Text))
            llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from reclamos.acciones where idcompania = " + Ctool.cia + " and id = " + txtcod.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtdescripcion.Text = dt.Rows[0]["descripcion"].ToString().Trim();
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);
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
            txtcod.Enabled = vtip;
            txtdescripcion.Enabled = vtip;
            Rbact.Enabled  = vtip;
            Rbinac.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtdescripcion.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if(!string.IsNullOrEmpty(txtcod.Text))
            llenarcampos();
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

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcod.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Campo descripcion es obligatorio, favor revisar.");
                txtdescripcion.Focus();
                return;
            }
            string vcod = txtcod.Text.Trim(),vdes = txtdescripcion.Text.Trim();
            int vest = Convert.ToInt32(Rbact.Checked);
            Ctool.ExcSql($"exec reclamos.proc_acciones @idcomp = {Ctool.cia} ,@id = {vcod},@des = '{vdes}',@est = {vest} ");
            if (Ctool.OcError)
            {
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
            Ctool.ExcSql($"delete from reclamos.acciones  where idcompania = {Ctool.cia} and id = {vcod}");
            if (Ctool.OcError)
            {
                return;
            }

            llenargrid();
            limpiar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            FrmConsAcciones frm = new FrmConsAcciones();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtcod.Text = Ctool.vretorno.Trim();
                llenarcampos();
                Ctool.vretorno = String.Empty;
            }
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                buscar();
            }
        }
    }
}
