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
    public partial class FrmConsReclamos : Form
    {
        public FrmConsReclamos()
        {
            InitializeComponent();
            Codigo.DataPropertyName = "id";
            Cliente.DataPropertyName = "cliente";
            Reclamo.DataPropertyName = "Reclamo";
            Fecha.DataPropertyName = "fecha";
            Estado.DataPropertyName = "estado";
            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            txtbuscar.Focus();
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select top(100) id,Convert(varchar(10),idcliente)+' - '+Rtrim(nombre)+' '+Rtrim(Apellidos) as cliente,fecha,convert(varchar(10),idtipo)+' - '+descripcion as reclamo,case when estado = 1 then 'En Proceso' else 'Terminado' end as estado  from V_Reclamos_Niveles where idcompania = " + Ctool.cia + vfil + " order by nivel desc");
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Ctool.vretorno = String.Empty;
            Close();
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string vbus = txtbuscar.Text.Trim().Replace("'", "");
                if (vbus.Length == 0)
                    llenargrid("");
                else
                llenargrid($" and (Rtrim(nombre)+' '+Rtrim(Apellidos) like '%{vbus}%' or descripcion like '%{vbus}%')");
            }
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            string vbus = txtbuscar.Text.Trim().Replace("'", "");
            if (vbus.Length == 0)
                llenargrid("");
            else
                llenargrid($" and (Rtrim(nombre)+' '+Rtrim(Apellidos) like '%{vbus}%' or descripcion like '%{vbus}%')");

        }

        private void FrmConsReclamos_Load(object sender, EventArgs e)
        {

        }

        private void Btnselec_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Ctool.vretorno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (Ctool.vretorno.Trim().Length > 0)
                    Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Ctool.vretorno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (Ctool.vretorno.Trim().Length > 0)
                    Close();
            }
        }
    }
}
