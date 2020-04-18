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
    public partial class FrmReclamosAcciones : Form
    {
        public FrmReclamosAcciones()
        {
            InitializeComponent();
            limpiar();
            CodigoRe.DataPropertyName = "idtipo";
            NombreRe.DataPropertyName = "desre";
            CodigoAc.DataPropertyName = "idaccion";
            NombreAc.DataPropertyName = "desac";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);
        }

        private void camposlec(bool vtip)
        {
            txtidaccion.Enabled = vtip;
            txtidreclamo.Enabled = vtip;
            numrepresenta.Enabled = vtip;
            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select idtipo,desre,idaccion,desac  from V_Tipos_Reclamos_Acciones2 where idcompania = " + Ctool.cia + vfil + " order by idtipo desc");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }

        private void limpiar(bool a = true)
        {
            numrepresenta.Value = 0;
            Rbact.Checked = true;
            Rbinac.Checked = false; 
            if (a)
            {
                txtidaccion.Text = String.Empty;
                txtdesaccion.Text = String.Empty;
                txtidreclamo.Text = String.Empty;
                txtnomreclamo.Text = String.Empty;
                txtidreclamo.Focus();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            numrepresenta.Focus();
        }

        private void txtidreclamo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtidaccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtidreclamo_Validating(object sender, CancelEventArgs e)
        {
            llenarreclamos();
            llenarcampos();

        }

        private void llenarreclamos()
        {
            if (String.IsNullOrEmpty(txtidreclamo.Text.Trim()))
                return;

            DataTable dt = Ctool.ExcSqlDT($"select descripcion from reclamos.Tipo_Reclamos where idcompania = {Ctool.cia} and id = {txtidreclamo.Text.Trim()} and estado = 1");
            if (dt.Rows.Count > 0)
                txtnomreclamo.Text = dt.Rows[0]["descripcion"].ToString();
            else
                txtnomreclamo.Text = "Error. Reclamo no existe";
        }

        private void txtidaccion_Validating(object sender, CancelEventArgs e)
        {
            llenaraccion();
            llenarcampos();
        }

        private void llenarcampos()
        {
            if (String.IsNullOrEmpty(txtidaccion.Text.Trim()) || String.IsNullOrEmpty(txtidreclamo.Text.Trim()))
                return;

            DataTable dt = Ctool.ExcSqlDT($"select * from reclamos.Tipos_Reclamos_Acciones where idcompania = {Ctool.cia} and idtipo = {txtidreclamo.Text.Trim()} and idaccion = {txtidaccion.Text.Trim()}");
            if (dt.Rows.Count > 0)
            {
                numrepresenta.Value = Convert.ToInt32(dt.Rows[0]["representa"]);
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);

                llenaraccion();
                llenarreclamos();
                camposlec(false);
                numrepresenta.Focus();
            }
            else
            {
                camposlec(true);
                limpiar(false);
            }

        }

        private void llenaraccion()
        {
            if (String.IsNullOrEmpty(txtidaccion.Text.Trim()))
                return;

            DataTable dt = Ctool.ExcSqlDT($"select descripcion from reclamos.Acciones where idcompania = {Ctool.cia} and id = {txtidaccion.Text.Trim()} and estado = 1");
            if (dt.Rows.Count > 0)
                txtdesaccion.Text = dt.Rows[0]["descripcion"].ToString();
            else
                txtdesaccion.Text = "Error. Accion no existe";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtidreclamo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                txtidaccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            }

            llenarcampos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtidreclamo.Text.Trim()))
            {
                MessageBox.Show("No. Reclamo es un campo obligatorio, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidreclamo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtidaccion.Text.Trim()))
            {
                MessageBox.Show("No. Accion es un campo obligatorio, Favor revisar.", "ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }
            if (!Ctool.valexitbl("reclamos.Tipo_Reclamos", $"idcompania= {Ctool.cia} and id = {txtidreclamo.Text.Trim()} and estado = 1"))
            {
                MessageBox.Show("No. Reclamo no existe, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidreclamo.Focus();
                return;
            }
            if (!Ctool.valexitbl("reclamos.Acciones", $"idcompania= {Ctool.cia} and id = {txtidaccion.Text.Trim()} and estado = 1")) 
            {
                MessageBox.Show("No. Accion no existe, Favor revisar.", "ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }
            int vest = 0;
            if (Rbact.Checked)
                vest = 1;
 
            string veje = $"Exec Reclamos.Proc_Tipos_Reclamos_Acciones  @idcompania = {Ctool.cia},@idtipo={txtidreclamo.Text.Trim()},@idaccion = {txtidaccion.Text.Trim()}";
            veje += $",@representa = {numrepresenta.Value.ToString().Trim()},@estado = {vest}";
            Ctool.ExcSql(veje);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimiento de salvar Tipos_Reclamos_Acciones.");
                return;
            }
            llenargrid();
            limpiar();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtidreclamo.Text.Trim()))
            {
                MessageBox.Show("No. Reclamo es un campo obligatorio, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidreclamo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtidaccion.Text.Trim()))
            {
                MessageBox.Show("No. Accion es un campo obligatorio, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }
            if (!Ctool.valexitbl("reclamos.Tipo_Reclamos", $"idcompania= {Ctool.cia} and id = {txtidreclamo.Text.Trim()} and estado = 1"))
            {
                MessageBox.Show("No. Reclamo no existe, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidreclamo.Focus();
                return;
            }
            if (!Ctool.valexitbl("reclamos.Acciones", $"idcompania= {Ctool.cia} and id = {txtidaccion.Text.Trim()} and estado = 1"))
            {
                MessageBox.Show("No. Accion no existe, Favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("Estas seguro que desea desabilitar registro?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                string vejec = String.Format("Update Reclamos.Tipos_Reclamos_Acciones set estado = 0 where idcompania = {0} and idaccion = {1} and idtipo = {2}", Ctool.cia, txtidaccion.Text.Trim(), txtidreclamo.Text.Trim());
                Ctool.ExcSql(vejec);
                if (Ctool.OcError)
                {
                    MessageBox.Show("Error Deshabilitando registro.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                limpiar();
            }



        }
    }
}
