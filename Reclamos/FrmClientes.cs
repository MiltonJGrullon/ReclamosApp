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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            limpiar();
            Codigo.DataPropertyName = "id";
            Nombre.DataPropertyName = "nombre";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            camposlec(true);

        }

        private void camposlec(bool vtip = true)
        {
            txtcoddep.Enabled = vtip;
            txtnombre.Enabled = vtip;
            txtapellido.Enabled = vtip;
            txtel.Enabled = vtip;
            txtcel.Enabled = vtip;
            txtemail.Enabled = vtip;
            txtdir.Enabled = vtip;
            txtcodpais.Enabled = vtip;
            txtcodprovincia.Enabled = vtip;
            txtcodmunicipio.Enabled = vtip;
            txtcodsector.Enabled =vtip;
            txtcodcalle.Enabled = vtip;
            txtcodparaje.Enabled = vtip;
            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
            btnmodificar.Enabled = !vtip;
            btnsalvar.Enabled = vtip;
            btnborrar.Enabled = vtip;
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id,Rtrim(nombre)+' '+Rtrim(Apellidos) as Nombre  from V_Clientes where idcompania = " + Ctool.cia + vfil + " order by id desc");
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
            txtel.Text = string.Empty;
            txtcel.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtdir.Text = string.Empty;
            txtcodpais.Text = string.Empty;
            txtnompais.Text = string.Empty;
            txtcodprovincia.Text = string.Empty;
            txtnomprovincia.Text = string.Empty;
            txtcodmunicipio.Text = string.Empty;
            txtmunicipio.Text = string.Empty;
            txtsector.Text = string.Empty;
            txtcodsector.Text = string.Empty;
            txtcalle.Text = string.Empty;
            txtcodcalle.Text = string.Empty;
            txtparaje.Text = string.Empty;
            txtcodparaje.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false; 

            if (a)
            {
                txtcoddep.Text = string.Empty;
                txtcoddep.Focus();
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtcoddep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodpais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodprovincia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodmunicipio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodsector_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodparaje_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodcalle_KeyPress(object sender, KeyPressEventArgs e)
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
            limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            txtnombre.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            txtcoddep.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            if (!string.IsNullOrEmpty(txtcoddep.Text))
                llenarcampos();
        }

        private void llenarcampos()
        {
            DataTable dt = Ctool.ExcSqlDT("Select * from V_Clientes_Direcciones where idcompania = " + Ctool.cia + " and id = " + txtcoddep.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtnombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtapellido.Text = dt.Rows[0]["apellidos"].ToString();

                txtdir.Text = dt.Rows[0]["referencia"].ToString();
                txtcodpais.Text = dt.Rows[0]["idpais"].ToString();
                txtnompais.Text = dt.Rows[0]["pais"].ToString();
                txtcodprovincia.Text = dt.Rows[0]["idprovincia"].ToString();
                txtnomprovincia.Text = dt.Rows[0]["provincia"].ToString();
                txtcodmunicipio.Text = dt.Rows[0]["idmunicipio"].ToString();
                txtmunicipio.Text = dt.Rows[0]["municipio"].ToString();
                txtsector.Text = dt.Rows[0]["sector"].ToString();
                txtcodsector.Text = dt.Rows[0]["idsector"].ToString();
                txtcalle.Text = dt.Rows[0]["calle"].ToString();
                txtcodcalle.Text = dt.Rows[0]["idcalle"].ToString();
                txtparaje.Text = dt.Rows[0]["paraje"].ToString();
                txtcodparaje.Text = dt.Rows[0]["idparaje"].ToString();
                Rbact.Checked = Convert.ToBoolean(dt.Rows[0]["estado"]);
                Rbinac.Checked = !Convert.ToBoolean(dt.Rows[0]["estado"]);

                string vterid = dt.Rows[0]["idtercero"].ToString();
                DataTable dttels = Ctool.ExcSqlDT("Select * from Entidad.Telefonos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                txtel.Text = txtcel.Text = txtemail.Text = String.Empty;
                foreach (DataRow item in dttels.Rows)
                {
                    if (Convert.ToInt32(item["idtipo"]) == 1)
                    {
                        txtel.Text = item["telefono"].ToString();
                    }
                    else if(Convert.ToInt32(item["idtipo"]) == 2)
                    {
                        txtcel.Text = item["telefono"].ToString();
                    }
                }
                DataTable dtcor = Ctool.ExcSqlDT("Select * from Entidad.Correos where idcompania = " + Ctool.cia + " and idterceros = " + vterid);
                if (dtcor.Rows.Count > 0)
                {
                    txtemail.Text = dtcor.Rows[0]["correo"].ToString();
                }
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
            if (string.IsNullOrEmpty(txtcoddep.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcoddep.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                MessageBox.Show("Campo nombre es obligatorio, favor revisar.");
                txtnombre.Focus();
                return;
            }

            string vcod = txtcoddep.Text.Trim(), vnom = txtnombre.Text.Trim(), vape = txtapellido.Text.Trim(), vtel = txtel.Text.Trim(), vcel = txtcel.Text.Trim(), vcor = txtemail.Text.Trim(), vdir = txtdir.Text.Trim();
            string vidpais = String.IsNullOrEmpty(txtcodpais.Text.Trim()) ? "0" : txtcodpais.Text.Trim(), vidprov = String.IsNullOrEmpty(txtcodprovincia.Text.Trim()) ? "0" : txtcodprovincia.Text.Trim();
            string vidmuni = String.IsNullOrEmpty(txtcodmunicipio.Text.Trim()) ? "0" : txtcodmunicipio.Text.Trim(), vidsec = String.IsNullOrEmpty(txtcodsector.Text.Trim()) ? "0" : txtcodsector.Text.Trim();
            string   vidcalle = String.IsNullOrEmpty(txtcodcalle.Text.Trim()) ? "0" : txtcodcalle.Text.Trim(),vidpar = String.IsNullOrEmpty(txtcodparaje.Text.Trim()) ? "0" : txtcodparaje.Text.Trim();
            string vest = "1";
            if(!Rbact.Checked) vest = "0";

            if (vidpais != "0")
            if(!Ctool.valexitbl("Dir.Pais",$"id = {vidpais}"))
            {

                MessageBox.Show($"Pais No. {vidpais} No existe, Favor Revisar.","ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Error );
                txtcodpais.Focus();
                return;
            }

            if (vidprov != "0")
            if(!Ctool.valexitbl("Dir.Provincias", $"idpais = {vidpais} and id = {vidprov}"))
            {

                MessageBox.Show($"Provincia No. {vidpais} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodprovincia.Focus();
                return;
            }

            if (vidmuni != "0")
            if(!Ctool.valexitbl("Dir.Municipios", $"idpais = {vidpais} and idprovincia = {vidprov} and id = {vidmuni}"))
            {

                MessageBox.Show($"Municipio No. {vidmuni} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodmunicipio.Focus();
                return;
            }
            if (vidsec != "0")
            if(!Ctool.valexitbl("Dir.Sector", $"idpais = {vidpais} and idprovincia = {vidprov} and  idmunicipio = {vidmuni} and id = {vidsec}"))
            {

                MessageBox.Show($"Sector No. {vidsec} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodsector.Focus();
                return;
            }

            if (vidpar != "0")
            if (!Ctool.valexitbl("Dir.Paraje", $"idpais = {vidpais} and idprovincia = {vidprov} and  idmunicipio = {vidmuni} and idsector = {vidsec} and id = {vidpar}"))
            {

                MessageBox.Show($"Paraje No. {vidpar} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodparaje.Focus();
                return;
            }
            if (vidcalle != "0")                
            if(!Ctool.valexitbl("Dir.Calles", $"idpais = {vidpais} and idprovincia = {vidprov} and  idmunicipio = {vidmuni} and idsector = {vidsec} and idparaje = {vidpar} and id = {vidcalle}"))
            {

                MessageBox.Show($"Calle No. {vidcalle} No existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodcalle.Focus();
                return;
            }

            if (!String.IsNullOrEmpty(vdir) && (vidpais == "0" ||  vidprov == "0" || vidmuni == "0" || vidsec == "0" || vidpar == "0" ||  vidcalle == "0"))
            {
                MessageBox.Show($"Debes completar correctamente todos los campos de (Pais,Provincia,Municipio,Sector,Paraje y calle) para especificar una direccion descriptiva, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdir.Focus();
                return;
            }

            if ((vidpais == "0" || vidprov == "0" || vidmuni == "0" || vidsec == "0" || vidpar == "0" || vidcalle == "0") &&
                (vidpais != "0" || vidprov != "0" || vidmuni  != "0" || vidsec != "0" || vidpar != "0" || vidcalle != "0"))
            {
                MessageBox.Show($"Debes completar todos los campos de (Pais,Provincia,Municipio,Sector,Paraje y calle) para especificar una direccion descriptiva, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodpais.Focus();
                return;
            }

            string v1 = $"exec Entidad.Proc_Clientes  @idcompania = {Ctool.cia} , @id = {vcod} , @idtipo = 1 , @nom = '{vnom}',";
            v1 += $"@ape = '{vape}',@tel = '{vtel}',@cel ='{vcel}', @correo ='{vcor}',";
            v1 += $"@pais  = {vidpais} , @prov  = {vidprov} , @muni  = {vidmuni} ,@sec = {vidsec} , @par = {vidpar} ,";
            v1 += $"@calle = {vidcalle} , @dir = '{vdir}' , @est = {vest}";
            Ctool.ExcSql(v1);
            if (Ctool.OcError)
            {
                MessageBox.Show("Ocurrio un error en el procedimiento de salvar.");
                return;
            }
            llenargrid();
            limpiar();

        }

        private void txtcodpais_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodpais.Text.Trim()))
                txtnompais.Text = Ctool.nomdir("Dir.Pais", $"id = {txtcodpais.Text.Trim()}");
            else
                txtnompais.Text = string.Empty;

        }

        private void txtcodprovincia_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodprovincia.Text.Trim()))
                txtnomprovincia.Text = Ctool.nomdir("Dir.Provincias", $"id = {txtcodprovincia.Text.Trim()} and idpais = {txtcodpais.Text.Trim()}");
            else
                txtnomprovincia.Text = string.Empty;
        }

        private void txtcodmunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodmunicipio.Text.Trim()))
                txtmunicipio.Text = Ctool.nomdir("Dir.Municipios", $" id = {txtcodmunicipio.Text.Trim()} and idprovincia = {txtcodprovincia.Text.Trim()} and idpais = {txtcodpais.Text.Trim()}");
            else
                txtmunicipio.Text = string.Empty;
        }

        private void txtcodsector_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodsector.Text.Trim()))
                txtsector.Text = Ctool.nomdir("Dir.Sector", $"id = {txtcodsector.Text.Trim()} and idmunicipio = {txtcodmunicipio.Text.Trim()} and idprovincia = {txtcodprovincia.Text.Trim()} and idpais = {txtcodpais.Text.Trim()}");
            else
                txtsector.Text = string.Empty;
        }

        private void txtcodparaje_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodparaje.Text.Trim()))
                txtparaje.Text = Ctool.nomdir("Dir.Paraje", $" id = {txtcodparaje.Text.Trim()} and idsector = {txtcodsector.Text.Trim()} and idmunicipio = {txtcodmunicipio.Text.Trim()} and idprovincia = {txtcodprovincia.Text.Trim()} and idpais = {txtcodpais.Text.Trim()}");
            else
                txtparaje.Text = string.Empty;
        }

        private void txtcodcalle_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcodcalle.Text.Trim()))
                txtcalle.Text = Ctool.nomdir("Dir.Calles", $" id = {txtcodcalle.Text.Trim()} and idparaje = {txtcodparaje.Text.Trim()} and idsector = {txtcodsector.Text.Trim()} and idmunicipio = {txtcodmunicipio.Text.Trim()} and idprovincia = {txtcodprovincia.Text.Trim()} and idpais = {txtcodpais.Text.Trim()}");
            else
                txtcalle.Text = string.Empty;
        }

        private void txtcoddep_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcoddep.Text))
                llenarcampos();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcoddep.Text.Trim()))
            {
                MessageBox.Show("Campo codigo es obligatorio, favor revisar.");
                txtcoddep.Focus();
                return;
            }

            if  (Ctool.ExcSqlDT($"select id  from V_Clientes where idcompania =  {Ctool.cia} and id = { txtcoddep.Text.Trim()} ").Rows.Count == 0) return;

            DialogResult dresult = MessageBox.Show($"Esta seguro que desea borrar el id cliente : {txtcoddep.Text.Trim()} ?", "ReclamosApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {

                string veje = $"Update Entidad.clientes set Estado = 0 where idcompania =  {Ctool.cia} and id = { txtcoddep.Text.Trim()} ";
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
    }
}
