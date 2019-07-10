using Cdbc.Common.Data.Type;
using Cdbc.Data.Client;
using CodeSamples.Common;
using System;
using System.Data;



namespace CodeSamples.Oracle
{
    public class OracleDataAdapterSample
    {

        /*
         * 
  CREATE TABLE "CODE_SAMPLE" 
   ("VAR1" VARCHAR2(36 BYTE) NOT NULL ENABLE, 
	"NUM1" NUMBER(8,0), 
	"DATE1" DATE, 
	"CLOB1" CLOB, 
	"BLOB1" BLOB, 
	 CONSTRAINT "CODE_SAMPLE_PK" PRIMARY KEY ("VAR1")
   ) 
         * 
         * */

        private const DatabaseProductType databaseProductType = DatabaseProductType.Oracle;

        public static void DataAdapter_Fill_Sample()
        {
            Console.WriteLine(String.Format("{0} DataAdapter_Fill_Sample", databaseProductType.ToString()));

            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr = "SELECT :VAR1 AS COLUMN1 FROM DUAL";
            CdbcCommand cmd = new CdbcCommand(queryStr, con);

            string guid = Guid.NewGuid().ToString();
            CdbcParameter para = new CdbcParameter(":VAR1", CdbcOracleDbType.Varchar2);
            para.Direction = ParameterDirection.Input;
            para.Value = guid;
            cmd.Parameters.Add(para);

            try
            {


                CdbcDataAdapter adap = new CdbcDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Sql : " + queryStr);
                Console.WriteLine("Parameter : VAR1=" + guid);
                Console.WriteLine("--------------------------");

                Console.WriteLine("Expected value:" + guid);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Console.WriteLine("Actual value:" + ds.Tables[0].Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("End");

        }


        public static void DataAdapter_FillSchema_Sample()
        {

            Console.WriteLine(String.Format("{0} DataAdapter_FillSchema_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr = "SELECT * FROM USER_TABLES";
            CdbcCommand cmd = new CdbcCommand(queryStr, con);
            CdbcDataAdapter adap = new CdbcDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Sql : " + queryStr);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Result:");



            try
            {
                DataTable dt2 = adap.FillSchema(dt1, SchemaType.Mapped);

                for (int iColumn = 0; iColumn < dt1.Columns.Count; iColumn++)
                {
                    Console.WriteLine(String.Format("ColumnName:{0}  DataType:{1}  MaxLength:{2}", dt1.Columns[iColumn].ColumnName, dt1.Columns[iColumn].DataType, dt1.Columns[iColumn].MaxLength));
                }

                for (int iColumn = 0; iColumn < dt2.Columns.Count; iColumn++)
                {
                    Console.WriteLine(String.Format("ColumnName:{0}  DataType:{1}  MaxLength:{2}", dt2.Columns[iColumn].ColumnName, dt2.Columns[iColumn].DataType, dt2.Columns[iColumn].MaxLength));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("End");

        }



        public static void DataAdapter_Update_Sample()
        {

            Console.WriteLine(String.Format("{0} DataAdapter_Update_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");
            Console.WriteLine("This sample will show you how to use CdbcDataAdapter.update insert ,update and delete data.");

            string guid = Guid.NewGuid().ToString();

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);


            try
            {

                //Sample 1 :Add new row (insert)
                Console.WriteLine("--------------------------");
                Console.WriteLine("Sample 1 : Insert a record into table CODE_SAMPLE");
                Console.WriteLine("--------------------------");

                string queryStrInsert = @"SELECT VAR1,NUM1,DATE1,CLOB1,BLOB1 FROM CODE_SAMPLE WHERE VAR1=:VAR1";
                CdbcCommand cmdInsert = new CdbcCommand(queryStrInsert, con);
                CdbcDataAdapter adapInsert = new CdbcDataAdapter(cmdInsert);
                CdbcCommandBuilder cb = new CdbcCommandBuilder(adapInsert);
                DataTable dt1 = new DataTable();


                adapInsert.FillSchema(dt1, SchemaType.Mapped);

                DataRow dr1 = dt1.NewRow();
                dr1["VAR1"] = guid;
                dr1["NUM1"] = DateTime.Now.Second;
                dr1["DATE1"] = DateTime.Now;
                dr1["CLOB1"] = "testclob";
                //  dr1["BLOB1"] = System.IO.File.ReadAllBytes(@"your file path");
                dt1.Rows.Add(dr1);
                int i = adapInsert.Update(dt1);
                Console.WriteLine(String.Format("{0} Line(s) inserted.", i));


                //Sample 2 :Edit row data (update)

                Console.WriteLine("--------------------------");
                Console.WriteLine("Sample 2 : update the record we inserted before.");
                Console.WriteLine("--------------------------");

                string queryStrUpdate = @"SELECT VAR1,NUM1,DATE1,CLOB1,BLOB1 FROM CODE_SAMPLE WHERE VAR1=:VAR1";
                CdbcCommand cmdUpdate = new CdbcCommand(queryStrUpdate, con);
                CdbcParameter para = new CdbcParameter(":VAR1", CdbcOracleDbType.Varchar2);
                para.Value = guid;
                cmdUpdate.Parameters.Add(para);

                CdbcDataAdapter adapUpdate = new CdbcDataAdapter(cmdUpdate);
                CdbcCommandBuilder cbUpdate = new CdbcCommandBuilder(adapUpdate);
                DataSet dsUpdate = new DataSet();
                adapUpdate.Fill(dsUpdate);
                dsUpdate.Tables[0].Rows[0]["NUM1"] = DateTime.Now.Second;
                dsUpdate.Tables[0].Rows[0]["DATE1"] = DateTime.Now;

                i = adapUpdate.Update(dsUpdate, dsUpdate.Tables[0].TableName);

                Console.WriteLine(String.Format("{0} Line(s) updated.", i));

                //Sample 3 :Delete row  (delete)
                Console.WriteLine("--------------------------");
                Console.WriteLine("Sample 3 : Delete the record we inserted before.");
                Console.WriteLine("--------------------------");

                DataSet dsDelete = new DataSet();
                adapUpdate.Fill(dsDelete);
                dsDelete.Tables[0].Rows[0].Delete();
                i = adapUpdate.Update(dsDelete.Tables[0]);
                //The following code will have same result.
                //i = adapUpdate.Update(dsDelete, dsDelete.Tables[0].TableName);

                Console.WriteLine(String.Format("{0} Line(s) Deleted.", i));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("end");

        }

        public static void DataAdapter_MultiFill_Sample()
        {

            Console.WriteLine(String.Format("{0} DataAdapter_MultiFill_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");

            Console.WriteLine("--------------------------");
            Console.WriteLine("DataAdapter.MultiFill is original Method of CdbcDataAdapter.");
            Console.WriteLine("It can fill multi select commands into multi datatables while access the database.");
            Console.WriteLine("It is designed to reduce call count and improve performance.");
            Console.WriteLine("--------------------------");


            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            CdbcDataAdapter adap = new CdbcDataAdapter();

            string queryStr1 = "SELECT TABLE_NAME FROM ALL_TABLES";
            CdbcCommand cmd = new CdbcCommand(queryStr1, con);
            adap.AddMultiSelectCommand(cmd, "ALL_TABLES");

            string queryStr2 = "SELECT DISTINCT OBJECT_TYPE FROM ALL_OBJECTS";
            cmd = new CdbcCommand(queryStr2, con);
            adap.AddMultiSelectCommand(cmd, "ALL_OBJECTS");

            DataSet ds = new DataSet();

            try
            {
                adap.MultiFill(ds);
                Console.WriteLine("--------------------------");
                Console.WriteLine("SQL 1 :" + queryStr1);
                Console.WriteLine("SQL 2 :" + queryStr2);
                Console.WriteLine("--------------------------");

                for (int iTable = 0; iTable < ds.Tables.Count; iTable++)
                {
                    Console.WriteLine("");
                    Console.WriteLine(ds.Tables[iTable].TableName);
                    for (int iRow = 0; iRow < ds.Tables[iTable].Rows.Count; iRow++)
                    {
                        Console.WriteLine(String.Format("{0}:{1}", ds.Tables[iTable].Columns[0].ColumnName, ds.Tables[iTable].Rows[iRow][0]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End");
        }
    }
}

