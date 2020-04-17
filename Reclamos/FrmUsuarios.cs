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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            limpiar();
            Codigo.DataPropertyName = "id";
            Nombre.DataPropertyName = "nombre";
            dataGridView1.AutoGenerateColumns = false;
            txtclave.Enabled = true;
            Chkmodificar.Enabled = false;

            llenargrid();
            camposlec(true);
        }

        private void camposlec(bool vtip)
        {
            txtidtipo.Enabled = vtip;
            txtnombre.Enabled = vtip;
            txtapellido.Enabled = vtip;
            txtel.Enabled = vtip;
            txtcorreo.Enabled = vtip;
            txtusuario.Enabled = vtip;
            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
            txtcod.Enabled = vtip;
            Chkautorizar.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id,Rtrim(nombre)+' '+Rtrim(Apellidos) as Nombre  from V_Usuarios where idcompania = " + Ctool.cia + vfil + " order by id desc");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }

        private void limpiar(bool a = true)
        {
            txtidtipo.Text = string.Empty;
            txtnomtipo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtel.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txtusuario.Text = string.Empty;
            txtclave.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false;
            Chkautorizar.Checked = true;
            Chkmodificar.Checked = false;
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

        private void txtidtipo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtclave.Enabled = true;
            camposlec(true);
            limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtnombre.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                txtcod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();

            llenarcampos();
        }

        private void llenarcampos()
        {
            if (string.IsNullOrEmpty(txtcod.Text))
                return;

            DataTable dt = Ctool.ExcSqlDT("Select * from V_Usuarios where idcompania = " + Ctool.cia + " and id = " + txtcod.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtclave.Enabled = false;
                Chkmodificar.Enabled = true;
                txtnombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtapellido.Text = dt.Rows[0]["apellidos"].ToString();
                txtidtipo.Text = dt.Rows[0]["idtipo"].ToString();
                txtclave.Text = dt.Rows[0]["clave"].ToString();
                txtusuario.Text = dt.Rows[0]["usuario"].ToString();

                Chkautorizar.Checked = Convert.ToBoolean(dt.Rows[0]["autorizar"]);
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);

                string vterid = dt.Rows[0]["idterceros"].ToString();
                DataTable dttels = Ctool.ExcSqlDT("Select * from Entidad.Telefonos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                txtel.Text = txtcorreo.Text = String.Empty;
                foreach (DataRow item in dttels.Rows)
                {
                    if (Convert.ToInt32(item["idtipo"]) == 1)
                    {
                        txtel.Text = item["telefono"].ToString();
                    }
                    else if (txtel.Text.Trim().Length == 0)
                    {
                        txtel.Text = item["telefono"].ToString();
                    }
                }
                DataTable dtcor = Ctool.ExcSqlDT("Select * from Entidad.Correos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                if (dtcor.Rows.Count > 0)
                {
                    txtcorreo.Text = dtcor.Rows[0]["correo"].ToString();
                }

                llenartipo();
                camposlec(false);
                txtnombre.Focus();
            }
            else
            {
                Chkmodificar.Enabled = false;
                camposlec(true);
                limpiar(false);
            }
        }

        private void llenartipo()
        {
            if (txtidtipo.Text.Trim().Length == 0)
                return;

            DataTable dt = Ctool.ExcSqlDT("Select nombre from Gen.Tipos_Usuarios where idcompania = " + Ctool.cia + " and id = " + txtidtipo.Text.Trim());
            if (dt.Rows.Count > 0)
                txtnomtipo.Text = dt.Rows[0][0].ToString().Trim();
            else
                txtnomtipo.Text = String.Empty;

        }

        private void txtidtipo_Validating(object sender, CancelEventArgs e)
        {
            llenartipo();
        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            llenarcampos();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcod.Focus();
                return;
            }

            if (Ctool.ExcSqlDT($"select id  from V_usuarios where idcompania =  {Ctool.cia} and id = { txtcod.Text.Trim()} ").Rows.Count == 0) return;

            DialogResult dresult = MessageBox.Show($"Esta seguro que desea borrar el id usuario : {txtcod.Text.Trim()} ?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {

                string veje = $"Update Entidad.usuarios set Estado = 0 where idcompania =  {Ctool.cia} and id = { txtcod.Text.Trim()} ";
                Ctool.ExcSql(veje);
                if (Ctool.OcError)
                {
                    MessageBox.Show("Ocurrio un error en el proceso de desactivar usuarios.");
                    return;
                }
                llenargrid();
                limpiar();
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text.Trim()))
                txtcod.Text = "0";

            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                MessageBox.Show("Campo nombre es obligatorio, favor revisar.");
                txtnombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtusuario.Text.Trim()))
            {
                MessageBox.Show("Campo Usuario es obligatorio, favor revisar.");
                txtusuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtclave.Text.Trim()))
            {
                MessageBox.Show("Campo clave es obligatorio, favor revisar.");
                txtcod.Focus();
                return;
            }

            int vcod,vidtipo,vest,vautorizar;
            string vnom, vape, vcor, vtel, vusu, vcla;
            vcod = Convert.ToInt32(txtcod.Text.Trim());
            vidtipo = Convert.ToInt32(txtidtipo.Text.Trim());
            vest = Convert.ToInt32(Rbact.Checked);
            vautorizar = Convert.ToInt32(Chkautorizar.Checked);
            vnom = txtnombre.Text.Trim();
            vape = txtapellido.Text.Trim();
            vtel = txtel.Text.Trim();
            vcor = txtcorreo.Text.Trim();
            vusu = txtusuario.Text.Trim();
            vcla = txtclave.Text.Trim();

            if (!txtclave.Enabled)
                vcla = String.Empty;

            String v1 = String.Format("Exec Entidad.Proc_Usuarios @idcompania = {0},@id = {1},@nom = '{2}',@ape = '{3}'",Ctool.cia,vcod,vnom,vape);
            String v2 = String.Format(",@tel = '{0}',@correo = '{1}',@idtipo = {2},@usuario = '{3}'", vtel, vcor, vidtipo, vusu);
            String v3 = String.Format(",@clave = '{0}',@autorizar = {1},@usuarioreg = '{2}',@estado = {3}", vcla, vautorizar, Ctool.usuario, vest);
            Ctool.ExcSql(v1 + v2 + v3);
            if (Ctool.OcError)
            {
                MessageBox.Show("Error. En el procedimiento Entidad.Proc_Usuarios.","ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            llenargrid();
            limpiar(); 
        }

        private void Chkmodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkmodificar.Checked)
            {
                txtclave.Enabled = true;
                txtclave.Text = string.Empty;
                txtclave.Focus();
            }
            else
            {
                txtclave.Text = string.Empty;
                txtclave.Enabled = false;
            }

        }
    }
}

