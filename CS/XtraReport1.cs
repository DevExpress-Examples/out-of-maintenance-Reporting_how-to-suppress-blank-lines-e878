using System;
using DevExpress.XtraReports.UI;
// ...

namespace SuppressBlankLines {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            // Get the current value of the "Fax" data column
            string faxName = GetCurrentColumnValue("Fax").ToString();

            // Check if the value is null, then cancel the printing
            //if (faxName == "") e.Cancel = true;
            if(faxName == "")
                ((XRLabel)sender).Text = String.Empty;
            else
                ((XRLabel)sender).Text = "Fax";
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            // Get the current value of the "Fax" data column
            string faxName = GetCurrentColumnValue("Fax").ToString();

            // Check if the value is null, then cancel the printing
            //if (faxName == "") e.Cancel = true;
            if(faxName == "")
                ((XRLabel)sender).Text = String.Empty;
        }

    }
}
