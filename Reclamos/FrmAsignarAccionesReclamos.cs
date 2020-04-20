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
    public partial class FrmAsignarAccionesReclamos : Form
    {
        public FrmAsignarAccionesReclamos()
        {
            InitializeComponent();
            Accion.DataPropertyName = "descripcion";
            dataGridView1.AutoGenerateColumns = false;

            idaccion.DataPropertyName = "idaccion";
            Accionnom.DataPropertyName = "descripcion";
            CodEmp.DataPropertyName = "idempleado";
            NomEmp.DataPropertyName = "nombreemp";
            Fechaini.DataPropertyName = "finicio";
            Fechafin.DataPropertyName = "ffin";
            dataGridView2.AutoGenerateColumns = false;
            llenargridrecomendado();
            llenargridacciones();
            limpiar();
            camposlec(true);
        }

        private void camposlec(bool vtip)
        { 
            txtidaccion.Enabled = vtip; 
            txtidemp.Enabled = vtip;
            fechaf.Enabled = vtip;
            fechai.Enabled = vtip;
            horaf.Enabled = vtip;
            horai.Enabled = vtip;
            txtnota.Enabled = vtip;
            cmbestado.Enabled = vtip;
            Btnprocesar.Enabled = vtip;
            Btnagregar.Enabled = vtip;
            Btnlimpiar.Enabled = vtip;
            Btnborrar.Enabled = vtip;
        }

        private void limpiar()
        {
            txtcod.Text = string.Empty;
            txtidtiporec.Text = string.Empty;
            txtdestiporeclamo.Text = string.Empty;
            txtcodcli.Text = string.Empty;
            txtnomcli.Text = string.Empty;
            txtdir.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txtidope.Text = string.Empty;
            txtdesope.Text = string.Empty;
            txtnotareclamo.Text = string.Empty;
            txtidaccion.Text = string.Empty;
            txtdesaccion.Text = string.Empty;
            txtidemp.Text = string.Empty;
            txtnomemp.Text = string.Empty;
            fecha.Value = DateTime.Now;
            fechaf.Value = DateTime.Now;
            fechai.Value = DateTime.Now;
            horaf.Value = DateTime.Now;
            horai.Value = DateTime.Now;
            txtnota.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            llenargridrecomendado();
            llenargridacciones();
            txtcod.Focus();
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
            }

        }

        DataTable dtdatag1 = new DataTable();
        DataTable dtdataacciones = new DataTable();
        private void llenargridrecomendado(string vfil = " and 1=2")
        {
            dtdatag1 = Ctool.ExcSqlDT($"select descripcion from V_Tipos_Reclamos_Acciones where idcompania = {Ctool.cia} and estado = 1  {vfil}");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdatag1;
        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if(!String.IsNullOrEmpty(txtcod.Text.Trim()))
                llenarcampos();
        }

        private void llenarcampos()
        {
            if (String.IsNullOrEmpty(txtcod.Text.Trim()))
                return;

            DataTable dt = new DataTable();
            dt = Ctool.ExcSqlDT($"select * from V_Transacciones_Reclamos where idcompania = {Ctool.cia} and id = {txtcod.Text.Trim()}");
            if (dt.Rows.Count > 0)
            {
                if (!Convert.ToBoolean(dt.Rows[0]["estado"]))
                {
                    MessageBox.Show("Aviso. Transaccion ya fue marcada como terminada.","ReclamosApp",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    camposlec(false);
                }
                txtidtiporec.Text = dt.Rows[0]["idtipo"].ToString();
                txtdestiporeclamo.Text = dt.Rows[0]["descripcion"].ToString();
                txtnotareclamo.Text = dt.Rows[0]["nota"].ToString();
                txtidope.Text = dt.Rows[0]["idoperador"].ToString();
                txtdesope.Text = dt.Rows[0]["nombre"].ToString()+" "+ dt.Rows[0]["apellidos"].ToString();
                txtcodcli.Text = dt.Rows[0]["idcliente"].ToString();
                fecha.Value = Convert.ToDateTime(dt.Rows[0]["fecha"]);
 
                llenargridacciones();
                llenarclientes();
                llenargridrecomendado($" and idtipo = {txtidtiporec.Text.Trim()}");
                

                limpiarac();
                txtidaccion.Focus();
            }
            else
            {
                MessageBox.Show("Numero de reclamo digitado no es correcto, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Text = string.Empty;
                txtcod.Focus();
                return;
            }
            
        }

        private void llenargridacciones(string vfil = "")
        {
            string vcod;
            vcod = txtcod.Text.Trim();
            if (string.IsNullOrEmpty(vcod)) vcod = "0";
            dtdataacciones = Ctool.ExcSqlDT($"Select idaccion,descripcion,idempleado,nombre+' '+Apellidos as nombreemp,finicio,convert(varchar(20), finicio, 108) as horai,ffin,convert(varchar(20), ffin, 108) as horaf,nota from V_Transacciones_Detalles where idcompania = {Ctool.cia} and id = {txtcod.Text.Trim()}");
            dataGridView2.DataSource = dtdataacciones;
        }

        private void alerta()
        {
            if (txtcod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de reclamo debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            camposlec(true);
            limpiar();

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

        private void txtidemp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarac();
            txtidaccion.Focus();
        }

        private void limpiarac()
        {
            txtidaccion.Text = string.Empty;
            txtdesaccion.Text = string.Empty;
            txtidemp.Text = string.Empty;
            txtnomemp.Text = string.Empty;
            fechaf.Value = DateTime.Now;
            fechai.Value = DateTime.Now;
            horaf.Value = DateTime.Now;
            horai.Value = DateTime.Now;
            txtnota.Text = string.Empty;
        }

        private void txtidaccion_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void txtidemp_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void fechai_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void horai_Enter(object sender, EventArgs e)
        {
            alerta();
        }
         

        private void fechaf_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void horaf_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void txtnota_Enter(object sender, EventArgs e)
        {
            alerta();
        }

        private void Lblaccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscaraccion();
        }

        private void buscaraccion()
        {
            FrmConsAcciones frm = new FrmConsAcciones();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtidaccion.Text = Ctool.vretorno.Trim();
                llenaraccion();
                Ctool.vretorno = String.Empty;
            }
        }

        private void llenaraccion()
        {
            if (String.IsNullOrEmpty(txtidaccion.Text.Trim())) return;


            DataTable dt = Ctool.ExcSqlDT("Select * from reclamos.acciones where idcompania = " + Ctool.cia + " and id = " + txtidaccion.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtdesaccion.Text = dt.Rows[0]["descripcion"].ToString().Trim();

                foreach (DataRow item in dtdataacciones.Rows)
                {
                    if (item["idaccion"].ToString().Trim() == txtidaccion.Text.Trim())
                    {
                        txtidemp.Text = item["idempleado"].ToString().Trim();
                        txtnomemp.Text = item["nombreemp"].ToString().Trim();
                        fechai.Value = Convert.ToDateTime(item["finicio"]);
                        fechaf.Value = Convert.ToDateTime(item["ffin"]);
                        horai.Value = Convert.ToDateTime(item["horai"]);
                        horaf.Value = Convert.ToDateTime(item["horaf"]);
                        txtnota.Text = item["nota"].ToString().Trim();
                    }
                }
            }
            else
            {
                txtdesaccion.Text = String.Empty;
            }
        }

        private void txtidaccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                buscaraccion();
        }

        private void lblempleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscaremp();
        }

        private void buscaremp()
        {
            FrmConsEmpleados frm = new FrmConsEmpleados();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(Ctool.vretorno))
            {
                txtidemp.Text = Ctool.vretorno.Trim();
                llenaremp();
                Ctool.vretorno = String.Empty;
            }
        }

        private void llenaremp()
        {
            if (String.IsNullOrEmpty(txtidemp.Text.Trim())) return;
            DataTable dt = Ctool.ExcSqlDT("Select * from V_Operador_Departamento where idcompania = " + Ctool.cia + " and id = " + txtidemp.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtnomemp.Text = dt.Rows[0]["nombre"].ToString()+" "+ dt.Rows[0]["apellidos"].ToString();
            }
            else
            {
                txtnomemp.Text = String.Empty;
            }
        }

        private void txtidaccion_Validating(object sender, CancelEventArgs e)
        {
            llenaraccion();
        }

        private void txtidemp_Validating(object sender, CancelEventArgs e)
        {
            llenaremp();
        }

        private void txtidemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                buscaremp();
            }
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de reclamo debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
                return;
            }

            if (txtidaccion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de accion debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }

            if (txtidemp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de accion debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidemp.Focus();
                return;
            }

            if (!Ctool.valexitbl($"Reclamos.Acciones",$" idcompania = {Ctool.cia} and id = {txtidaccion.Text.Trim()}"))
            {
                MessageBox.Show("Numero de accion no existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }

            if (!Ctool.valexitbl($"Entidad.Empleados", $" idcompania = {Ctool.cia} and id = {txtidemp.Text.Trim()}"))
            {
                MessageBox.Show("Numero de accion no existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }
            string vidaccion, videmp, vdesaccion, vnomemp, vnota,vfechai,vfechaf, vhorai, vhoraf;
            vidaccion = txtidaccion.Text.Trim();
            videmp = txtidemp.Text.Trim();
            vdesaccion = txtdesaccion.Text.Trim();
            vnomemp = txtnomemp.Text.Trim();
            vnota = txtnota.Text.Trim();
            vfechai = fechai.Value.ToString("dd/MM/yyyy"); 
            vhorai = horai.Value.ToString("HH:mm:ss");
            vfechaf = fechaf.Value.ToString("dd/MM/yyyy");
            vhoraf = horaf.Value.ToString("HH:mm:ss");

            bool vent = false;
            foreach (DataRow item in dtdataacciones.Rows)
            {
                if (item["idaccion"].ToString().Trim() == vidaccion)
                {
                    item["descripcion"] = vdesaccion;
                    item["idempleado"] = videmp;
                    item["nombreemp"] = vnomemp;
                    item["nota"] = vnota; 
                    item["finicio"] = vfechai;
                    item["horai"] = vhorai;
                    item["ffin"] = vfechaf;
                    item["horaf"] = vhoraf;
                    vent = true;
                }
            }

            if (!vent)
            {
                DataRow dtr = dtdataacciones.NewRow();
                dtr["idaccion"] = vidaccion;
                dtr["descripcion"] = vdesaccion;
                dtr["idempleado"] = videmp;
                dtr["nombreemp"] = vnomemp;
                dtr["nota"] = vnota;
                dtr["finicio"] = vfechai;
                dtr["horai"] = vhorai;
                dtr["ffin"] = vfechaf;
                dtr["horaf"] = vhoraf;
                dtdataacciones.Rows.Add(dtr);
            }
            dataGridView2.DataSource = dtdataacciones;

            limpiarac();
            txtidaccion.Focus();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                string vid = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtidaccion.Text = vid;
                llenaraccion();
            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {

            if (txtcod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de reclamo debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
                return;
            }

            if (txtidaccion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de accion debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            } 

            if (!Ctool.valexitbl($"Reclamos.Acciones", $" idcompania = {Ctool.cia} and id = {txtidaccion.Text.Trim()}"))
            {
                MessageBox.Show("Numero de accion no existe, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidaccion.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show($"Esta seguro que desea borrar No. Accion: {txtidaccion.Text.Trim()}?","ReclamosApp",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            foreach (DataRow item in dtdataacciones.Rows)
            {
                if (item["idaccion"].ToString().Trim() == txtidaccion.Text.Trim())
                {
                    dtdataacciones.Rows.Remove(item);
                    break; 
                }
            }
            limpiarac();
            txtidaccion.Focus();
        }

        private void Btnprocesar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de reclamo debe de ser especificado, Favor Revisar.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
                return;
            }
            if (cmbestado.SelectedIndex == 1)
            {
                Ctool.ExcSql($"Update reclamos.Transacciones set estado = 0,HoraDespachado = getdate() where idcompania = {Ctool.cia} and id = {txtcod.Text.Trim()}");
                if (Ctool.OcError)
                {
                    MessageBox.Show("Error Actualizado  tabla reclamos.Transacciones.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Ctool.ExcSql($"Delete from reclamos.Transacciones_Detalle  where idcompania = {Ctool.cia} and id = {txtcod.Text.Trim()}");
            if (Ctool.OcError)
            {
                MessageBox.Show("Error Borrando en tabla reclamos.Transacciones_Detalle.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            String v1 = "INSERT INTO[reclamos].[Transacciones_Detalle] ([idcompania],[id],[idaccion],[idempleado],[finicio],[ffin],[Nota],[estado])";
            String v2, vidac, videmp, vfechai, vfechaf, vnota;

            foreach (DataRow item in dtdataacciones.Rows)
            {
                vidac=  item["idaccion"].ToString().Trim();
                videmp = item["idempleado"].ToString().Trim();
                vnota = item["nota"].ToString().Trim();
                vfechai= Convert.ToDateTime(item["finicio"]).ToString("yyyy-MM-dd")+" "+ Convert.ToDateTime(item["horai"]).ToString("HH:mm:ss");
                vfechaf = Convert.ToDateTime(item["ffin"]).ToString("yyyy-MM-dd") +" "+ Convert.ToDateTime(item["horaf"]).ToString("HH:mm:ss");
                v2 = String.Format(" VALUES ({0},{1},{2},{3},'{4}','{5}','{6}',{7})",Ctool.cia,txtcod.Text.Trim(),vidac,videmp,vfechai,vfechaf,vnota,1);
                Ctool.ExcSql(v1 + v2);
                if (Ctool.OcError)
                {
                    MessageBox.Show("Error Insertando en tabla reclamos.Transacciones_Detalle.", "ReclamosApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            limpiar();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            buscarreclamos();
        }

        private void buscarreclamos()
        {
            FrmConsReclamos frm = new FrmConsReclamos();
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
                buscarreclamos();
            }
        }
    }
}
