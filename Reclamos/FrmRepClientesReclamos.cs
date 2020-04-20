using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reclamos
{
    public partial class FrmRepClientesReclamos : Form
    {
        public FrmRepClientesReclamos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Focus();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

            string v1 = " SELECT Count(*) as Cantidad,reclamos.Transacciones.idcompania, reclamos.Transacciones.idcliente, dbo.V_Clientes.apellidos+' '+dbo.V_Clientes.nombre as nomcli";
            string v2 = " FROM reclamos.Transacciones INNER JOIN";
            string v3 = " dbo.V_Clientes ON reclamos.Transacciones.idcompania = dbo.V_Clientes.idcompania AND reclamos.Transacciones.idcliente = dbo.V_Clientes.id";
            string v4 = $" WHERE (reclamos.Transacciones.idcompania = {Ctool.cia}) and (reclamos.Transacciones.fecha BETWEEN '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}')";
            string v5 = " GROUP BY reclamos.Transacciones.idcompania, reclamos.Transacciones.idcliente, dbo.V_Clientes.apellidos, dbo.V_Clientes.nombre";

             string vcmd = v1 + v2 + v3+v4+v5;
            var dt = Ctool.ExcSqlDT(vcmd);
            if (Ctool.OcError)
            {
                MessageBox.Show("Error select reclamos");
                return;
            }
            var Res = dt.AsEnumerable()
                .Select(x => new Reclamosxclientes()
                {
                    idcompania = x.Field<int>("idcompania"),
                    cantidad = x.Field<int>("Cantidad"),
                    idcliente = x.Field<int>("idcliente"),
                    nomcli = x.Field<string>("nomcli"),
                }).OrderByDescending(x => x.cantidad).ToList();

            var frmp = new FrmReporte();
            var rv = frmp.Rpv;
            rv.Clear();
            rv.Reset();
            if (rv.LocalReport.DataSources.Any())
                rv.LocalReport.DataSources.Clear();

            //ok, prueba.
            rv.LocalReport.ReportEmbeddedResource = "Reclamos.rep.ReportReclamosCli.rdlc";
            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("PrmUno", "Reclamos APP"));
            rv.LocalReport.SetParameters(reportParameters);

            //PrmUno
            rv.LocalReport.DataSources.Add(new ReportDataSource("DsCliRecl", Res));


            rv.RefreshReport();

            frmp.ShowDialog();
        }
    }
}
