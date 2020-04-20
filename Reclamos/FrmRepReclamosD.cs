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
    public partial class FrmRepReclamosD : Form
    {
        public FrmRepReclamosD()
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
            string v1 = "SELECT  idcompania,id,idtipo,descripcion,idcliente,nombre+' '+Apellidos as nomcli,fecha,nota";
            string v2 = " FROM V_Reclamos_Detallado  ";
            string v3 = $" WHERE idcompania = {Ctool.cia} and  FECHA BETWEEN '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}'";
            string vcmd = v1 + v2 + v3 ;
            var dt = Ctool.ExcSqlDT(vcmd);
            if (Ctool.OcError)
            {
                MessageBox.Show("Error select reclamos");
                return;
            }
            var Res = dt.AsEnumerable()
                .Select(x => new Reclamosdetalle()
                {
                    idcompania = x.Field<int>("idcompania"),
                    id = x.Field<int>("id"),
                    idtipo = x.Field<int>("idtipo"),
                    idcliente = x.Field<int>("idcliente"),
                    fecha = x.Field<DateTime>("fecha"),
                    nomcli = x.Field<string>("nomcli"),
                    nomrec = x.Field<string>("descripcion"),
                    nota = x.Field<string>("nota"),
                }).OrderBy(x => x.id).ToList();

            var frmp = new FrmReporte();
            var rv = frmp.Rpv;
            rv.Clear();
            rv.Reset();
            if (rv.LocalReport.DataSources.Any())
                rv.LocalReport.DataSources.Clear();

            //ok, prueba.
            rv.LocalReport.ReportEmbeddedResource = "Reclamos.rep.ReportReclamosD.rdlc";
            List<ReportParameter> reportParameters = new List<ReportParameter>();
            reportParameters.Add(new ReportParameter("PrmUno", "Reclamos APP"));
            rv.LocalReport.SetParameters(reportParameters);

            //PrmUno
            rv.LocalReport.DataSources.Add(new ReportDataSource("DsReclamosD", Res));


            rv.RefreshReport();

            frmp.ShowDialog();
        }
    }
}
