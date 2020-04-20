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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroDeTiposDeReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposReclamos frm = new FrmTiposReclamos();
            frm.ShowDialog();
        }

        private void registroDeNivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNivel frm = new FrmNivel();
            frm.ShowDialog();
        }

        private void registroDeAccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcciones frm = new FrmAcciones();
            frm.ShowDialog();
        }

        private void registroDeDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frm = new FrmDepartamentos();
            frm.ShowDialog();
        }

        private void registroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReclamos frm = new FrmReclamos();
            frm.ShowDialog();
        }

        private void establecerDependientesDeAccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcciones_Dependientes frm = new FrmAcciones_Dependientes();
            frm.ShowDialog();
        }

        private void establecerAccionesDeLosReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReclamosAcciones frm = new FrmReclamosAcciones();
            frm.ShowDialog();
        }

        private void registroDeOperadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperadores frm = new FrmOperadores();
            frm.ShowDialog();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void registroDeTiposDeCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposCorreos frm = new FrmTiposCorreos();
            frm.ShowDialog();
        }

        private void registroDeTiposRedesSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposRedesSociales frm = new FrmTiposRedesSociales();
            frm.ShowDialog();
        }

        private void tiposDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposClientes frm = new FrmTiposClientes();
            frm.ShowDialog();
        }

        private void tiposDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposEmpleados frm = new FrmTiposEmpleados();
            frm.ShowDialog();
        }

        private void tiposDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposDirecciones frm = new FrmTiposDirecciones();
            frm.ShowDialog();
        }

        private void tiposDocumentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposDocumentaciones frm = new FrmTiposDocumentaciones();
            frm.ShowDialog();
        }

        private void tipoTelefonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposTelefonos frm = new FrmTiposTelefonos();
            frm.ShowDialog();
        }

        private void tiposUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposUsuarios frm = new FrmTiposUsuarios();
            frm.ShowDialog();
        }

        private void seguimientosAReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignarAccionesReclamos frm = new FrmAsignarAccionesReclamos();
            frm.ShowDialog();
        }

        private void reclamosMasReportadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepReclamosAgrup frm = new FrmRepReclamosAgrup();
            frm.ShowDialog();
        }
    }
}
