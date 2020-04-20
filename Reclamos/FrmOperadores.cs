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
    public partial class FrmOperadores : Form
    {
        public FrmOperadores()
        {
            InitializeComponent();
            Codigo.DataPropertyName = "id";
            Nombre.DataPropertyName = "nombre";
            
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);

        }

        private void camposlec(bool vtip = true)
        {
            txtcod.Enabled = vtip;
            txtnombre.Enabled = vtip;
            txtapellido.Enabled = vtip;
            txtiddep.Enabled = vtip;
            Tentrada.Enabled = vtip;
            TSalida.Enabled = vtip;
            Tbreaki.Enabled = vtip;
            BreakF.Enabled = vtip;

            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        DataTable dtdata = new DataTable();

        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id,Rtrim(nombre)+' '+Rtrim(Apellidos) as Nombre  from V_operador where idcompania = " + Ctool.cia + vfil + " order by id desc");
           
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }
        private void limpiar(bool a = true)
        {

            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;

            txtiddep.Text = string.Empty;
            txtdesdep.Text = string.Empty;
            Tentrada.Text = string.Empty;
            TSalida.Text = string.Empty;
            Tbreaki.Text = string.Empty;
            BreakF.Text = string.Empty;


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

        private void btncancelar_Click(object sender, EventArgs e)
        {
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
            if (!string.IsNullOrEmpty(txtcod.Text))
                llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from V_Operador_Departamento where idcompania = " + Ctool.cia + " and id = " + txtcod.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtnombre.Text = dt.Rows[0]["nombre"].ToString();
                txtapellido.Text = dt.Rows[0]["apellidos"].ToString();

                txtiddep.Text = dt.Rows[0]["iddepartamento"].ToString();
                txtdesdep.Text = dt.Rows[0]["Descripcion"].ToString();
                Tentrada.Text = dt.Rows[0]["horaentrada"].ToString();
                TSalida.Text = dt.Rows[0]["horasalida"].ToString();
                Tbreaki.Text = dt.Rows[0]["horabreaki"].ToString();
                BreakF.Text = dt.Rows[0]["horabreaks"].ToString();
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);

               
                camposlec(false);
                txtnombre.Focus();
            }
            else
            {
                camposlec(true);
                limpiar(false);
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

            if (string.IsNullOrEmpty(Tentrada.Text.Trim()))
            {
                MessageBox.Show("Hora de entrada es obligatorio, favor revisar.");
                Tentrada.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TSalida.Text.Trim()))
            {
                MessageBox.Show("Hora de salida es obligatorio, favor revisar.");
                TSalida.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Tbreaki.Text.Trim()))
            {
                MessageBox.Show("Hora de inicio de tiempo libre es obligatorio, favor revisar.");
                Tbreaki.Focus();
                return;
            }

            if (string.IsNullOrEmpty(BreakF.Text.Trim()))
            {
                MessageBox.Show("Hora de fin del tiempo libre es obligatorio, favor revisar.");
                BreakF.Focus();
                return;
            }
            string vcod = txtcod.Text.Trim(),
                vnom = txtnombre.Text.Trim(),
                vape = txtapellido.Text.Trim(),
                vent = Tentrada.Value.ToString("HH:mm:ss"),
                vsal = TSalida.Value.ToString("HH:mm:ss"),
                vbrei = Tbreaki.Value.ToString("HH:mm:ss"),
                vbres = BreakF.Value.ToString("HH:mm:ss");

         
            string vest = "1";
            if (!Rbact.Checked) vest = "0";

            string viddep = String.IsNullOrEmpty(txtiddep.Text.Trim()) ? "0" : txtiddep.Text.Trim();

            if (!Ctool.valexitbl("reclamos.Departamentos", $"idcompania = {Ctool.cia} and Id = {viddep}"))
                {

                    MessageBox.Show($"Reclamo No. {viddep} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtiddep.Focus();
                    return;
                }

           

           //if (!String.IsNullOrEmpty(viddep) && (viddep == "0"))
           // {
           //     MessageBox.Show($"Debes completar correctamente todos el campo del (Departamento), Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     txtiddep.Focus();
           //     return;
           // }

           // if ((viddep == "0" ) &&
           //     (viddep != "0" ))
           // {
           //     MessageBox.Show($"Debes completar el campos de (Departamento), Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     txtiddep.Focus();
           //     return;
           // }

            string v1 = $"exec Entidad.proc_empleados  @idcompania = {Ctool.cia} , @id = {vcod} , @idtipo = 1 , @nom = '{vnom}',";
            v1 += $"@ape = '{vape}',@iddep = {viddep},@horaentrada ='{vent}', @horasalida ='{vsal}',";
            v1 += $"@horabreaki  = '{vbrei}' , @horabreaks  = '{vbres}' , @est  = {vest}";
            Ctool.ExcSql(v1);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimiento de salvar.");
                return;
            }
            llenargrid();
            limpiar();

        }

        private void txtiddep_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtiddep.Text.Trim()))
                txtdesdep.Text = Ctool.desdep("reclamos.Departamentos", $"id = {txtiddep.Text.Trim()}");
            else
                txtdesdep.Text = string.Empty;


        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcod.Text))
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

            if (Ctool.ExcSqlDT($"select id  from V_operador where idcompania =  {Ctool.cia} and id = { txtcod.Text.Trim()} ").Rows.Count == 0) return;

            DialogResult dresult = MessageBox.Show($"Esta seguro que desea borrar el id operador : {txtcod.Text.Trim()} ?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {

                string veje = $"Update Entidad.Empleados set Estado = 0 where idcompania =  {Ctool.cia} and id = { txtcod.Text.Trim()} ";
                Ctool.ExcSql(veje);
                if (Ctool.OcError)
                {
                    MessageBox.Show("Ocurrio un error en el proceso de desactivar operador");
                    return;
                }
                llenargrid();
                limpiar();
            }
        }
        private void FrmOperadores_Load(object sender, EventArgs e)
        {

        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                FrmConsEmpleados frm = new FrmConsEmpleados();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(Ctool.vretorno))
                {
                    txtcod.Text = Ctool.vretorno;
                    llenarcampos();
                    Ctool.vretorno = string.Empty;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
