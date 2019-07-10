using Cdbc.Common.Data.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSamples
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOracleSample_Click(object sender, EventArgs e)
        {
            OpenSample(DatabaseProductType.Oracle);
        }

        private void BtnSqlserverSample_Click(object sender, EventArgs e)
        {
            OpenSample(DatabaseProductType.SqlServer);
        }

        private void OpenSample(DatabaseProductType dbType)
        {
            this.Hide();
            FrmSamples frmSample = new FrmSamples(dbType);
            frmSample.ShowDialog();
            frmSample.Dispose();
            this.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
