using Cdbc.Common.Data.Type;
using Cdbc.Data.Client;
using System;
using System.Drawing;

namespace CodeSamples.Common
{
    public static class UtilCommon
    {

        public static String UserId="";
        public static String UserPsk = "";
        public static String ApplicationId = "";
        public static String ApplicationPsk = "";
        public static String connectionString = "";

        public static String NvlStr(object o)
        {
            if (o == null || o == DBNull.Value)
            {
                return "";
            }
            else
            {
                return o.ToString();
            }
        }


        public static CdbcConnection getConnection(DatabaseProductType databaseProductType)
        {
    
            CdbcConnection con = new CdbcConnection(connectionString);

            //In case of in CDBCservice's web.config.
            //  <userAuthentication authMethod="UserPsk">
            con.UserId = UtilCommon.UserId;
            con.UserPsk = UtilCommon.UserPsk;

            //In case of in CDBCservice's web.config.
            //  <userAuthentication authMethod="Basic">
            // con.UserId = "** userid **";
            // con.UserPassword = "**user password **";

            //In case of in CDBCservice's web.config.
            //  <userAuthentication authMethod="None">
            //You need not set UserId , UserPsk or UserPassword
            // <userAuthentication authMethod="None"> is not recommended for production use.


            //In case of in CDBCservice's web.config.
            //  <clientApplicationAuthentication authMethod="ApplicationPsk">
            con.ApplicationId = UtilCommon.ApplicationId;
            con.ApplicationPsk = UtilCommon.ApplicationPsk;

            //In case of in CDBCservice's web.config.
            //  <clientApplicationAuthentication authMethod="None">
            //You need not set ApplicationId or ApplicationPsk
            //  <clientApplicationAuthentication authMethod="None"> is not recommended for production use.

            con.DatabaseProduct = databaseProductType;
            return con;
        }

        public static Image ByteArrayToImage(byte[] b)
        {
            if (b == null) return null;

            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

    }
}
