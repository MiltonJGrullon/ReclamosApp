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
    public partial class FrmReclamos : Form
    {
        public FrmReclamos()
        {
            InitializeComponent();
            limpiar();
            Accion.DataPropertyName = "descripcion";
            dataGridView1.AutoGenerateColumns = false;
            camposlec(true);
            llenarreclamos();
            llenaroperadores();
            llenargrid();
        }

        DataTable dtope = new DataTable();
        private void llenaroperadores()
        {
            dtope = Ctool.ExcSqlDT($"select id,rtrim(nombre)+' '+rtrim(apellidos) as nom from V_Empleados where idcompania = {Ctool.cia} and idtipo = 1 and disponible = 1");
            cmboperador.DataSource = dtope;
            cmboperador.ValueMember = "id";
            cmboperador.DisplayMember = "nom";

        }

        DataTable dtrecla = new DataTable();
        private void llenarreclamos()
        {
            dtrecla = Ctool.ExcSqlDT($"select id,descripcion from Reclamos.Tipo_Reclamos where idcompania = {Ctool.cia}");
            cmbreclamos.DataSource = dtrecla;
            cmbreclamos.ValueMember = "id";
            cmbreclamos.DisplayMember = "descripcion";
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "0")
        {
            dtdata = Ctool.ExcSqlDT($"select descripcion from V_Tipos_Reclamos_Acciones where idcompania = {Ctool.cia} and estado = 1 and idtipo = {vfil}");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }
        private void camposlec(bool vtip)
        {
            txtcodcli.Enabled = vtip;
            txtnota.Enabled = vtip;
            cmboperador.Enabled = vtip;
            cmbreclamos.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            Btnaceptar.Enabled = vtip;
            btnprocesar.Enabled = false;
        }

        private void limpiar()
        {
            txtcod.Text = "????????";
            txtcodcli.Text = String.Empty;
            txtnomcli.Text = String.Empty;
            txtdir.Text = String.Empty;
            txttelefono.Text = String.Empty;
            txtcorreo.Text = String.Empty;
            txtnota.Text = String.Empty;
            fecha.Value = DateTime.Now;
            HoraA.Value = DateTime.Now;
            HoraD.Value = DateTime.Now;
            txtcodcli.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            limpiar();
            llenarreclamos();
            llenaroperadores();
            llenargrid();
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

        private void txtcodcli_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtcodcli.Focus();
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcodcli.Text.Trim()))
            {
                MessageBox.Show("Codigo del cliente, es obligatorio. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodcli.Focus();
                return;
            }
            DataTable dt = Ctool.ExcSqlDT($"select id from entidad.clientes where idcompania = {Ctool.cia} and id = {txtcodcli.Text.Trim()}");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Codigo del cliente, No existe. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodcli.Focus();
                return;
            }
            if (cmboperador.SelectedIndex < 0)
            {
                MessageBox.Show("Operador es obligatorio. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboperador.Focus();
                return;
            }

            if (cmbreclamos.SelectedIndex < 0)
            {
                MessageBox.Show("Debes de elegir un tipo de reclamo reportado por el cliente, favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbreclamos.Focus();
                return;
            }
            txtcodcli.Enabled = false;
            cmboperador.Enabled = false;
            cmbreclamos.Enabled = false;
            btnprocesar.Enabled = true;
            Btnaceptar.Enabled = false;

            if (!String.IsNullOrEmpty(cmbreclamos.SelectedValue.ToString()))
                llenargrid(cmbreclamos.SelectedValue.ToString());
        }

        private void txtcodcli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                buscarclientes();
            }
        }

        private void buscarclientes()
        {
            FrmConsClientes frm = new FrmConsClientes();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtcodcli.Text = Ctool.vretorno.Trim();
                llenarclientes();
                Ctool.vretorno = String.Empty;
            }
        }

        private void lblcliente_Click(object sender, EventArgs e)
        {
            buscarclientes();

        }

        private void txtcodcli_Validating(object sender, CancelEventArgs e)
        {
            llenarclientes();
        }

        private void llenarclientes()
        {
            txtnomcli.Text = txtdir.Text = txttelefono.Text = txtcorreo.Text = String.Empty;

            DataTable dt = Ctool.ExcSqlDT("Select * from V_Clientes_Direcciones where idcompania = " + Ctool.cia + " and id = " + txtcodcli.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtnomcli.Text = dt.Rows[0]["Nombre"].ToString() + " " + dt.Rows[0]["apellidos"].ToString();
                
                if (dt.Rows[0]["pais"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["pais"].ToString() + ", ";

                if (dt.Rows[0]["provincia"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["provincia"].ToString() + ", ";

                if (dt.Rows[0]["municipio"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["municipio"].ToString() + ", ";

                if (dt.Rows[0]["sector"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["sector"].ToString() + ", ";
                    
                if (dt.Rows[0]["sector"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["sector"].ToString() + ", ";

                if (dt.Rows[0]["calle"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["calle"].ToString() + ", ";

                if (dt.Rows[0]["referencia"].ToString().Length > 0)
                    txtdir.Text += dt.Rows[0]["referencia"].ToString() + "";
                
                string vterid = dt.Rows[0]["idtercero"].ToString();

                DataTable dttels = Ctool.ExcSqlDT("Select * from Entidad.Telefonos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                foreach (DataRow item in dttels.Rows)
                {
                    if (Convert.ToInt32(item["idtipo"]) == 1)
                    {
                        txttelefono.Text = item["telefono"].ToString();

                    }
                    else if (Convert.ToInt32(item["idtipo"]) == 2)
                    {
                        if (txttelefono.Text.Trim().Length == 0)
                        {
                            txttelefono.Text = item["telefono"].ToString();
                        }
                    }
                }
                DataTable dtcor = Ctool.ExcSqlDT("Select * from Entidad.Correos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                if (dtcor.Rows.Count > 0)
                {
                    txtcorreo.Text = dtcor.Rows[0]["correo"].ToString();
                }
                HoraA.Value = DateTime.Now;
            }

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcodcli.Text.Trim()))
            {
                MessageBox.Show("Codigo del cliente, es obligatorio. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodcli.Focus();
                return;
            }
            DataTable dt = Ctool.ExcSqlDT($"select id from entidad.clientes where idcompania = {Ctool.cia} and id = {txtcodcli.Text.Trim()}");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Codigo del cliente, No existe. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodcli.Focus();
                return;
            }
            if (cmboperador.SelectedIndex < 0)
            {
                MessageBox.Show("Operador es obligatorio. favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboperador.Focus();
                return;
            }

            if (cmbreclamos.SelectedIndex < 0)
            {
                MessageBox.Show("Debes de elegir un tipo de reclamo reportado por el cliente, favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbreclamos.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtnota.Text.Trim()))
            {
                MessageBox.Show("Debes colocar una nota sobre el problema, favor revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnota.Focus();
                return;
            }
            HoraD.Value = DateTime.Now;

            int vid = 0, vtiprec, vope, vidcli, vest = 1;
            string vnota,Vha,Vhd;

            if (txtcod.Text.Trim().Substring(0, 1) != "?")
                vid = Convert.ToInt32(txtcod.Text.Trim());

            vtiprec = Convert.ToInt32(cmbreclamos.SelectedValue);
            vope = Convert.ToInt32(cmboperador.SelectedValue);
            vidcli = Convert.ToInt32(txtcodcli.Text.Trim());
            vnota = txtnota.Text.Trim().Replace("'","");
            Vha = HoraA.Value.ToString("HH:mm:ss");
            Vhd = HoraD.Value.ToString("HH:mm:ss");

            string vexe = String.Format("Exec Reclamos.Proc_TransaccionesH  @idcompania = {0},@id ={1},@idtipo= {2}, @idcliente= {3},@idoperador= {4},@HoraAtendido= '{5}',@HoraDespachado= '{6}',@estado= {7},@nota= '{8}'", Ctool.cia, vid, vtiprec, vidcli, vope, Vha, Vhd, vest, vnota);
            Ctool.ExcSql(vexe);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimientol.","ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            camposlec(true);
            limpiar();
            llenarreclamos();
            llenaroperadores();
            llenargrid();
        }


    }
}
