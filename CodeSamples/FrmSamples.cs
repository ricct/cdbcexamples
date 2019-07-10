using Cdbc.Common.Data.Type;
using CodeSamples.Common;
using CodeSamples.Oracle;
using System;
using System.Windows.Forms;

namespace CodeSamples
{
    public partial class FrmSamples : Form
    {

        private DatabaseProductType databaseProductType;
        public FrmSamples()
        {
            InitializeComponent();
        }

        public FrmSamples(DatabaseProductType sampleDatabaseProductType)
        {
            InitializeComponent();
            this.CurrentDatabaseProductType = sampleDatabaseProductType;
            Console.SetOut(new ControlWriter(txtOutput));
        }
        private DatabaseProductType CurrentDatabaseProductType
        {
            get

            {
                return databaseProductType;
            }
            set
            {
                databaseProductType = value;
                this.Text = databaseProductType.ToString() + " Samples";
            }
        }

        private void setAuthenticationInfo()
        {
            UtilCommon.ApplicationId = this.txtApplicationID.Text;
            UtilCommon.ApplicationPsk = this.txtApplicationPsk.Text;
            UtilCommon.UserId = this.txtUserID.Text;
            UtilCommon.UserPsk = this.txtUserPsk.Text;
            UtilCommon.connectionString = this.txtConnectionString.Text;

        }

        private void RunSample(object sender, System.EventArgs e)
        {
            txtOutput.Clear();
            setAuthenticationInfo();

            string btn = ((Button)sender).Name;
            
            switch (databaseProductType)
            {
                case DatabaseProductType.Oracle:
                    //DataAdapter
                    if (btn.Equals(btnDataAdapterFill.Name))
                    {
                        OracleDataAdapterSample.DataAdapter_Fill_Sample();
                    }
                    else if (btn.Equals(btnDataAdapterFillSchema.Name))
                    {
                        OracleDataAdapterSample.DataAdapter_FillSchema_Sample();
                    }
                    else if (btn.Equals(btnDataAdapterUpdate.Name))
                    {
                        OracleDataAdapterSample.DataAdapter_Update_Sample();
                    }
                    else if (btn.Equals(btnDataAdapterMultiFill.Name))
                    {
                        OracleDataAdapterSample.DataAdapter_MultiFill_Sample();
                    }
                    //Command
                    else if (btn.Equals(btnCommandExecuteNonQuery.Name))
                    {
                        OracleCommandSample.Command_ExecuteNonQuery_Sample();
                    }
                    else if (btn.Equals(btnCommandExecuteScalar.Name))
                    {
                        OracleCommandSample.Command_ExecuteScalar_Sample();
                    }
                    else if (btn.Equals(btnCommandExecuteDbDataReader.Name))
                    {
                        OracleCommandSample.Command_ExecuteDbDataReader_Sample();
                    }
                    //OracleCommandCollectionSample
                    else if (btn.Equals(btnCommandCollectionExecuteMultiQuery.Name))
                    {
                        OracleCommandCollectionSample.CommandCollection_ExecuteMultiQuery_Sample();
                    }
                    break;
                case DatabaseProductType.SqlServer:

                    break;
                default:
                    
                    break;
            }

        }

        private void LblLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ricct/cdbcexamples");
        }
    }
}
