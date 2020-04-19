﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reclamos
{
    public partial class FrmConsTipEmp : Form
    {
        public FrmConsTipEmp()
        {
            InitializeComponent();
            id.DataPropertyName = "id";
            descripcion.DataPropertyName = "descripcion";

            dataGridView1.AutoGenerateColumns = false;
            llenargrid();
            txtbuscar.Focus();
        }

        DataTable dtdata = new DataTable();
        private void llenargrid(string vfil = "")
        {
            dtdata = Ctool.ExcSqlDT($"select id, descripcion from Gen.Tipos_Empleados where idcompania = {Ctool.cia} {vfil}");
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
                    llenargrid($" and (Descripcion like '%{vbus}%')");
            }
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            string vbus = txtbuscar.Text.Trim().Replace("'", "");
            if (vbus.Length == 0)
                llenargrid("");
            else
                llenargrid($" and (Descripcion like '%{vbus}%')");
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

        private void Btnselec_Click(object sender, EventArgs e)
        {
            Ctool.vretorno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (Ctool.vretorno.Trim().Length > 0)
                Close();
        }
    }
}
