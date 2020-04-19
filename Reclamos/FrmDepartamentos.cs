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

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select Id," +
                "Descripcion,Idencargado,Funcion,Estado " +
                "from reclamos.Departamentos where Idcompania = " + Ctool.cia + vfil);



            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }


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
            DataTable dt = Ctool.ExcSqlDT("Select * from V_Departamentos where Idcompania = " + Ctool.cia + " and Id = " + txtcoddep.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtdescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                txtidencargado.Text = dt.Rows[0]["Idencargado"].ToString();
                txtnomencargado.Text = dt.Rows[0]["nombre"].ToString()+" "+dt.Rows[0]["apellidos"].ToString();
                txtfuncion.Text = dt.Rows[0]["Funcion"].ToString();
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
            if (dataGridView1.Rows.Count > 0)
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

        private void txtidencrgado(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Campo Id Encargado es obligatorio, favor revisar.");
                txtidencargado.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtfuncion.Text.Trim()))
            {
                MessageBox.Show("Campo Funcion es obligatorio, favor revisar.");
                txtfuncion.Focus();
                return;
            }
            string vcod = txtcoddep.Text.Trim();
            string vdes = txtdescripcion.Text.Trim();

            string viden = String.IsNullOrEmpty(txtidencargado.Text.Trim()) ? "0" : txtidencargado.Text.Trim();

            string vfun = txtfuncion.Text.Trim();
            string vest = "1";
            if (!Rbact.Checked) vest = "0";




            string v1 = $"exec reclamos.Proc_Departamentos  @idcom = {Ctool.cia} , @id = {vcod} , @Des = '{vdes}' , @funcion= '{vfun}',";
            v1 += $"@idenc  = {viden} ,";
            v1 += $" @est = {vest}";

            Ctool.ExcSql(v1);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimiento de salvar.");
                return;
            }


            llenargrid();
            limpiar();
        }



        private void txtidencargado_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtidencargado.Text.Trim()))
                txtnomencargado.Text = Ctool.nomentidades("V_EMPLEADOS", $"idcompania = {Ctool.cia} and id = {txtidencargado.Text.Trim()}");
            else
                txtnomencargado.Text = string.Empty;

        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcoddep.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcoddep.Focus();
                return;
            }

            if (Ctool.ExcSqlDT($"select Id  from V_Departamentos where Idcompania =  {Ctool.cia} and Id = { txtcoddep.Text.Trim()} ").Rows.Count == 0) return;

            DialogResult dresult = MessageBox.Show($"Esta seguro que desea borrar el Departamento : {txtcoddep.Text.Trim()} ?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {

                string veje = $"Update reclamos.Departamentos set Estado = 0 where Idcompania =  {Ctool.cia} and Id = { txtcoddep.Text.Trim()} ";
                Ctool.ExcSql(veje);
                if (Ctool.OcError)
                {
                    MessageBox.Show("Ocurrio un error en el proceso de desactivar cliente.");
                    return;
                }
                llenargrid();
                limpiar();
            }
        }

        private void buscardepa()
        {
            FrmConsDepa frm = new FrmConsDepa();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtcoddep.Text = Ctool.vretorno.Trim();
                llenarcampos();
                Ctool.vretorno = String.Empty;
            }
        }
        private void txtcoddep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)

            {
                buscardepa();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscardepa();
        }
    }
}
