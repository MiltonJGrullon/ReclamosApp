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
    public partial class FrmTiposDirecciones : Form
    {
        public FrmTiposDirecciones()
        {
            InitializeComponent();
            limpiar();
            id.DataPropertyName = "id";
            nombre.DataPropertyName = "nombre";

            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);
        }

        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id, nombre from Gen.Tipos_Direcciones where idcompania = " + Ctool.cia);
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
            txtnombre.Text = string.Empty;


            if (a)
            {
                txtcod.Text = string.Empty;
                txtcod.Focus();
            }


        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcod.Text))
                llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from Gen.Tipos_Direcciones where idcompania = " + Ctool.cia + " and id = " + txtcod.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtnombre.Text = dt.Rows[0]["nombre"].ToString().Trim();

                camposlec(false);
                txtnombre.Focus();
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
            txtnombre.Enabled = vtip;

            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtnombre.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if (!string.IsNullOrEmpty(txtcod.Text))
                llenarcampos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if (!string.IsNullOrEmpty(txtcod.Text))
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
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                MessageBox.Show("Campo nombre es obligatorio, favor revisar.");
                txtnombre.Focus();
                return;
            }
            string vcod = txtcod.Text.Trim(), vdes = txtnombre.Text.Trim();

            Ctool.ExcSql($"exec Gen.proc_tdirecciones @idcompania = {Ctool.cia} ,@id = {vcod},@nombre = '{vdes}' ");
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
            Ctool.ExcSql($"delete from Gen.Tipos_Direcciones where idcompania = {Ctool.cia} and id = {vcod}");
            if (Ctool.OcError)
            {
                return;
            }

            llenargrid();
            limpiar();
        }
    }
}
