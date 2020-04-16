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
    public partial class FrmAcciones_Dependientes : Form
    {
        public FrmAcciones_Dependientes()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            txtidemp.Text = string.Empty;
            txtdesaccion.Text = string.Empty;
            txtcodaccion.Text = string.Empty;
            txtnomemp.Text = string.Empty;
            Rbact.Checked = true;
            Rbinac.Checked = false;
        }

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

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT("select id, nombre from Gen.Tipos_Clientes where idcompania = " + Ctool.cia);
            if (Ctool.OcError)
            {
                return;
            }
            dataGridView1.DataSource = dtdata;
        }

        private void camposlec(bool vtip)
        {
            txtidemp.Enabled = vtip;
            txtdesaccion.Enabled = vtip;
            txtcodaccion.Enabled = vtip;
            txtnomemp.Enabled = vtip;
            Rbact.Enabled = vtip;
            Rbinac.Enabled = vtip;
        }
    }
}
