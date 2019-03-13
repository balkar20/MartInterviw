using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;
using System.Data.SqlClient;
using System.Transactions;

namespace wcfservice
{
    [ServiceContract]
    public interface Iservice
    {
        [OperationContract]
        void upload();
    }


    public class serviceclass : Iservice
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void upload()
        {

            SqlConnection con = new SqlConnection(@"server=.; database = Database.mdf; Integrated security = true");
            SqlCommand cmd = new SqlCommand("Insert into emp values ('SS')");
            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();

            throw new FaultException();
        }
    }
}
