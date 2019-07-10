

using Cdbc.Common.Data.Type;
using Cdbc.Data;
using Cdbc.Data.Client;
using CodeSamples.Common;
using System;
using System.Data.Common;

namespace CodeSamples.Oracle
{
    public static class OracleCommandCollectionSample
    {
        private const DatabaseProductType databaseProductType = DatabaseProductType.Oracle;

        public static void CommandCollection_ExecuteMultiQuery_Sample()
        {

            Console.WriteLine(String.Format("{0} CommandCollection_ExecuteMultiQuery_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");

            Console.WriteLine("--------------------------");
            Console.WriteLine("CommandCollection.ExecuteMultiQuery is original Method of CdbcCommandCollection.");
            Console.WriteLine("It can execute multi command in same transaction.");
            Console.WriteLine("It is designed to improve performance and Data Concurrency and Consistency");
            Console.WriteLine("--------------------------");
            Console.WriteLine("This sample will insert 3 records and than update one of the record.");
            Console.WriteLine("--------------------------");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string queryStr1 = @"INSERT INTO CODE_SAMPLE(VAR1 , DATE1 ) VALUES (:VAR1, SYSDATE)";
            CdbcCommand cmd1 = new CdbcCommand(queryStr1, con);

            string[] arrParas = new string[3];

            for (int i = 0; i < arrParas.Length; i++)
            {
                arrParas[i] = Guid.NewGuid().ToString();
            }

            cmd1.ArrayBindCount = 3;
            CdbcParameter prm =
              new CdbcParameter("VAR1", CdbcOracleDbType.Varchar2);
            prm.Value = arrParas;
            cmd1.Parameters.Add(prm);

            string queryStr2 = @"UPDATE CODE_SAMPLE SET DATE1 = DATE1+1 WHERE VAR1=:VAR1";
            CdbcCommand cmd2 = new CdbcCommand(queryStr2, con);
            prm = new CdbcParameter("VAR1", CdbcOracleDbType.Varchar2);
            prm.Value = arrParas[0];
            cmd2.Parameters.Add(prm);


            Console.WriteLine("--------------------------");
            Console.WriteLine("SQL 1 :" + queryStr1);
            Console.WriteLine("Para 1 :" );

            for (int i = 0; i < arrParas.Length; i++)
            {
                Console.WriteLine(arrParas[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("SQL 2 :" + queryStr2);

            Console.WriteLine("--------------------------");
            try
            {
                CdbcCommandCollection cmdCollection = new CdbcCommandCollection();
                cmdCollection.Add(cmd1);
                cmdCollection.Add(cmd2);
                cmdCollection.ExecuteMultiQuery();

                for (int iCmd = 0; iCmd < cmdCollection.Count; iCmd++)
                {
                    Console.WriteLine(String.Format("Command {0} Result : {1} ", iCmd, cmdCollection.ExecuteNonQueryResult[iCmd].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            //Confirm Data
            Console.WriteLine("---Confirm Data-----------------------");
            string queryStrSelect = @"SELECT VAR1, DATE1 FROM CODE_SAMPLE WHERE VAR1 IN (:VAR1_0 ,:VAR1_1,:VAR1_2) ";
            CdbcCommand cmdSelect = new CdbcCommand(queryStrSelect, con);
            for (int i = 0; i < arrParas.Length; i++)
            {
                prm = new CdbcParameter("VAR1_" + i.ToString(), CdbcOracleDbType.Varchar2);
                prm.Value = arrParas[i];
                cmdSelect.Parameters.Add(prm);
            }

            try
            {
                DbDataReader reader = cmdSelect.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(String.Format("{0} = {1}", reader.GetName(i), reader.GetValue(i).ToString()));
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            //Clear Data
            Console.WriteLine("---Clear Data-----------------------");

            string queryStrDelete = @"DELETE FROM CODE_SAMPLE WHERE VAR1=:VAR1";
            CdbcCommand cmdDelete = new CdbcCommand(queryStrDelete, con);
            cmdDelete.ArrayBindCount = 3;
            prm =
              new CdbcParameter("VAR1", CdbcOracleDbType.Varchar2);
            prm.Value = arrParas;
            cmdDelete.Parameters.Add(prm);
            try
            {
                int i = cmdDelete.ExecuteNonQuery();

                Console.WriteLine(String.Format("{0} Line(s) Deleted.", i));
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
