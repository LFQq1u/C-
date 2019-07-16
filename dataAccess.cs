using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class dataAccess
    {
        OleDbConnection con;
        
        public void Datacon()
        {
            con = new OleDbConnection("provider = microsoft.jet.OleDb.4.0;Data Source = " + Application.StartupPath.ToString() + "//student.mdb;");
            
        }

        public DataSet Data(string comStr)
        {
            con.Open();
            try
            {
                OleDbCommand com = new OleDbCommand(comStr, con);

                OleDbDataAdapter da = new OleDbDataAdapter(com);

                DataSet ds = new DataSet();

                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public bool DataCom(string comStr)
        {
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("链接失败");
            }
            try
            {
                OleDbCommand com = new OleDbCommand(comStr, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }


    }
}
