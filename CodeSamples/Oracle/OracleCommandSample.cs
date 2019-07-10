using Cdbc.Common.Data.Type;
using Cdbc.Data.Client;
using CodeSamples.Common;
using System;
using System.Data.Common;

namespace CodeSamples.Oracle
{
    public static class OracleCommandSample
    {

        private const DatabaseProductType databaseProductType = DatabaseProductType.Oracle;


        public static void Command_ExecuteNonQuery_Sample()
        {

            Console.WriteLine(String.Format("{0} Command_ExecuteNonQuery_Sample", databaseProductType.ToString()));

            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr = @"INSERT INTO CODE_SAMPLE(VAR1, NUM1, DATE1, CLOB1, BLOB1) VALUES (:VAR1, :NUM1, :DATE1, :CLOB1, :BLOB1)";
            CdbcCommand cmd = new CdbcCommand(queryStr, con);

            string guid = Guid.NewGuid().ToString();

            CdbcParameter para = new CdbcParameter(":VAR1", CdbcOracleDbType.Varchar2);
            para.Value = guid;
            cmd.Parameters.Add(para);

            para = new CdbcParameter(":NUM1", CdbcOracleDbType.Decimal);
            para.Value = DateTime.Now.Second;
            cmd.Parameters.Add(para);

            para = new CdbcParameter(":DATE1", CdbcOracleDbType.Date);
            para.Value = DateTime.Now;
            cmd.Parameters.Add(para);

            para = new CdbcParameter(":CLOB1", CdbcOracleDbType.Clob);
            para.Value = DateTime.Now.Second;
            cmd.Parameters.Add(para);

            para = new CdbcParameter(":BLOB1", CdbcOracleDbType.Blob);
            //para.Value = System.IO.File.ReadAllBytes(@"your file path");
            cmd.Parameters.Add(para);


            Console.WriteLine("--------------------------");
            Console.WriteLine("Sample 1 : Insert a record into table CODE_SAMPLE");
            Console.WriteLine("Sql : " + queryStr);

            try
            {
                int i = cmd.ExecuteNonQuery();

                Console.WriteLine(String.Format("{0} Line(s) inserted.", i));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }


            string queryStrDelete = @"DELETE FROM CODE_SAMPLE WHERE VAR1=:VAR1";
            CdbcCommand cmdDelete = new CdbcCommand(queryStrDelete, con);
            para = new CdbcParameter(":VAR1", CdbcOracleDbType.Varchar2);
            para.Value = guid;
            cmdDelete.Parameters.Add(para);


            Console.WriteLine("--------------------------");
            Console.WriteLine("Sample 2 : Delete the record we inserted before.");
            Console.WriteLine("Sql : " + queryStrDelete);

            try
            {
                int i = cmdDelete.ExecuteNonQuery();

                Console.WriteLine(String.Format("{0} Line(s) deleted.", i));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("End");
        }


        public static void Command_ExecuteScalar_Sample()
        {

            Console.WriteLine(String.Format("{0} Command_ExecuteScalar_Sample", databaseProductType.ToString()));

            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr = @"SELECT :VAR1 AS A FROM DUAL";
            CdbcCommand cmd = new CdbcCommand(queryStr, con);

            string guid = Guid.NewGuid().ToString();

            CdbcParameter para = new CdbcParameter(":VAR1", CdbcOracleDbType.Varchar2);
            para.Value = guid;
            cmd.Parameters.Add(para);


            Console.WriteLine("--------------------------");
            Console.WriteLine("Sql : " + queryStr);
            Console.WriteLine("Parameter : VAR1=" + guid);
            Console.WriteLine("--------------------------");

            try
            {
                object o = cmd.ExecuteScalar();
                Console.WriteLine("Expected value:" + guid);
                Console.WriteLine("Actual value:" + o.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("End");
        }


        public static void Command_ExecuteDbDataReader_Sample()
        {
            Console.WriteLine(String.Format("{0} Command_ExecuteDbDataReader_Sample", databaseProductType.ToString()));

            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr = @"SELECT TABLE_NAME FROM ALL_TABLES";
            CdbcCommand cmd = new CdbcCommand(queryStr, con);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Sql : " + queryStr);
            Console.WriteLine("--------------------------");

            try
            {

                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(0).ToString());
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
    }
}