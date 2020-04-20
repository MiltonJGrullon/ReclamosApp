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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            Rpv.SetDisplayMode(DisplayMode.PrintLayout);
            Rpv.ZoomMode = ZoomMode.PageWidth;
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100% 
            // Rpv.ZoomMode = ZoomMode.Percent;
            //   Rpv.ZoomPercent = 100;
            Rpv.RefreshReport();
         }
    }
}
