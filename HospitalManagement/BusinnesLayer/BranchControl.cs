using HospitalManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace HospitalManagement.BusinnesLayer
{
    class BranchControl
    {
        public static List<Branch> getBranchs() //Branş listesini geriye döndürür.
        {
            OleDbCommand sqlCommand = Database.SqlCommand("select * from Branch");
            OleDbDataReader dataReader = sqlCommand.ExecuteReader();
            List<Branch> branchs = new List<Branch>();

            while (dataReader.Read())
            {
                Branch item = new Branch(
                    Convert.ToInt32(dataReader[0]),
                    dataReader[1].ToString());
                branchs.Add(item);
            }
            dataReader.Close();
            return branchs;
        }
    }
}
