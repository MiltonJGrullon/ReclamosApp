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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            linkolvide.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusuario.Text.Trim()))
            {
                MessageBox.Show("Usuario es obligatorio, favor digitar.", Ctool.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtclave.Text.Trim()))
            {
                MessageBox.Show("Clave es obligatorio, favor digitar.", Ctool.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclave.Focus();
                return;
            }
            string vuser = txtusuario.Text.Trim().Replace("'", "");
            string vpass = txtclave.Text.Trim().Replace("'", "");

            DataTable dt = Ctool.ExcSqlDT($"Select usuario from Entidad.Usuarios where idcompania =  { Ctool.cia }  and usuario = '{vuser}' and PwdCompare('{vpass}',clave) = 1");
            if (dt.Rows.Count > 0)
            {
                Hide();
                FrmMenuPrincipal frm = new FrmMenuPrincipal();
                frm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Datos no son correctos, favor revisar.", Ctool.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                linkolvide.Visible = true;
                return;
            }

        }

        private void linkolvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtusuario.Text.Trim()))
            {
                MessageBox.Show("Usuario es obligatorio, favor digitar.", Ctool.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                return;
            }
            string vuser = txtusuario.Text.Trim();
            DataTable dt = Ctool.ExcSqlDT($"Select usuario from Entidad.Usuarios where idcompania =  { Ctool.cia }  and usuario = '{vuser}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario no existe, favor revisar.", Ctool.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                return;
            }
        }
    }
}
