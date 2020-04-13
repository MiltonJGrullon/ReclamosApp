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
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
            limpiar();
            Codigo.DataPropertyName = "Id";
            Descripcion.DataPropertyName = "Descripcion";
            Idencargado.DataPropertyName = "Idencargado";
            Funcion.DataPropertyName = "Funcion";
            Estado.DataPropertyName = "Estado";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);
          
        }
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select Id," +
                "Descripcion,Idencargado,Funcion,Estado " +
                "from reclamos.Departamentos where idcompania = " + Ctool.cia);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            txtidencargado.Text = string.Empty;
            txtnomencargado.Text = string.Empty;
            txtfuncion.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false;

            if (a)
            {
                txtcoddep.Text = string.Empty;
                txtcoddep.Focus();
            }


        }

        private void txtcoddep_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcoddep.Text))
                llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from reclamos.Departamentos where Idcompania = " + Ctool.cia + " and Id = " + txtcoddep.Text.Trim());
            if (dt.Rows.Count > 0)
            {

                txtdescripcion.Text = dt.Rows[0]["Descripcion"].ToString().Trim();
                txtidencargado.Text = dt.Rows[0]["Idencargado"].ToString().Trim();
                txtfuncion.Text = dt.Rows[0]["Funcion"].ToString().Trim();
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["Estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["Estado"]);
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
            txtcoddep.Enabled = vtip;
            txtdescripcion.Enabled = vtip;
            txtidencargado.Enabled = vtip;
            txtnomencargado.Enabled = vtip;
            txtfuncion.Enabled = vtip;

            Rbact.Enabled = vtip;
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
            txtcoddep.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if (!string.IsNullOrEmpty(txtcoddep.Text))
                llenarcampos();
        }

        private void txtcoddep_KeyPress(object sender, KeyPressEventArgs e)
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
            if (string.IsNullOrEmpty(txtcoddep.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcoddep.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                MessageBox.Show("Campo descripcion es obligatorio, favor revisar.");
                txtdescripcion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtidencargado.Text.Trim()))
            {
                MessageBox.Show("Campo descripcion es obligatorio, favor revisar.");
                txtdescripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtfuncion.Text.Trim()))
            {
                MessageBox.Show("Campo descripcion es obligatorio, favor revisar.");
                txtdescripcion.Focus();
                return;
            }
            string vcod = txtcoddep.Text.Trim();
            string vdes = txtdescripcion.Text.Trim();

            string  vide = txtidencargado.Text.Trim();
            string vfun = txtfuncion.Text.Trim();
            int vest = Convert.ToInt32(Rbact.Checked);
            Ctool.ExcSql($"exec reclamos.proc_departamentos @Idcompania = {Ctool.cia}, @Id = {vcod},@Idencargado= {vide}, @Funcion== '{vfun}', @Descripcion = '{vdes}',@Estado = {vest} ");
            if (Ctool.OcError)
            {
                return;
            }

            llenargrid();
            limpiar();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcoddep.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcoddep.Focus();
                return;
            }

            string vcod = txtcoddep.Text.Trim();
            Ctool.ExcSql($"delete from reclamos.Departamentos  where Idcompania = {Ctool.cia} and Id = {vcod}");
            if (Ctool.OcError)
            {
                return;
            }

            llenargrid();
            limpiar();
        }
    }
}
