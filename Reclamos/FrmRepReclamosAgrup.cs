using Microsoft.Reporting.WinForms;
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
    public partial class FrmRepReclamosAgrup : Form
    {
        public FrmRepReclamosAgrup()
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

            string v1 = "SELECT COUNT(*) AS CANTIDAD, reclamos.Transacciones.idcompania, reclamos.Transacciones.idtipo, reclamos.Tipo_Reclamos.descripcion";
            string v2 = " FROM reclamos.Tipo_Reclamos INNER JOIN reclamos.Transacciones ON reclamos.Tipo_Reclamos.idcompania = reclamos.Transacciones.idcompania AND reclamos.Tipo_Reclamos.id = reclamos.Transacciones.idtipo";
            string v3 = $" WHERE reclamos.Transacciones.FECHA BETWEEN '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}'";
            string v4 = " GROUP BY reclamos.Transacciones.idcompania, reclamos.Transacciones.idtipo, reclamos.Tipo_Reclamos.descripcion";
            string vcmd = v1 + v2 + v3 + v4;
            var dt = Ctool.ExcSqlDT(vcmd);
            if (Ctool.OcError)
            {
                MessageBox.Show("Error select reclamos");
                return;
            }
            var Res = dt.AsEnumerable()
                .Select(x => new ReclamosAgrup()
                {
                    idcompania = x.Field<int>("idcompania"),
                    cantidad = x.Field<int>("cantidad"),
                    id = x.Field<int>("idtipo"),
                    descripcion = x.Field<string>("descripcion").Trim()
                }).OrderByDescending(x => x.cantidad).ToList();
 
            var frmp = new FrmReporte();
            var rv = frmp.Rpv;
            rv.Clear();
            rv.Reset();
            if (rv.LocalReport.DataSources.Any())
                rv.LocalReport.DataSources.Clear();

            //ok, prueba.
            rv.LocalReport.ReportEmbeddedResource = "Reclamos.rep.ReportModelo.rdlc";
            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("PrmUno", "Reclamos APP"));
            rv.LocalReport.SetParameters(reportParameters);

            //PrmUno
            rv.LocalReport.DataSources.Add(new ReportDataSource("DsNom", Res));


            rv.RefreshReport();

            frmp.ShowDialog();
        }
    }
}
