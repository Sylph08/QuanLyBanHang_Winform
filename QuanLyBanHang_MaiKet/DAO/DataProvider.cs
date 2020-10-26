using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLyBanHang_MaiKet
{
    class DataProvider
    {
        private static DataProvider instance;

        internal static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }
        private DataProvider() { }
        private string cntStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang_MK;Integrated Security=True";

        //execute query
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(cntStr))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(data);
                cnn.Close();
            }
            return data;
        }
        //execute nonquery
        public int ExecuteNonQuery (string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(cntStr))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                string[] listpara = query.Split(' ');
                int i = 0;
                foreach(string item in listpara)
                    if(item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                data=cmd.ExecuteNonQuery();
                cnn.Close();
            }
            
                return data;
        }
        public int ENQ_ForPicture(string query, byte[] img)
        {
            int data = 0;
            SqlConnection cnn = new SqlConnection(cntStr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            string[] listpara = query.Split(' ');
            int i = 0;
            foreach (string item in listpara)
                if (item.Contains('@'))
                {
                    cmd.Parameters.Add(new SqlParameter(item, img));
                    i++;
                }
            data = cmd.ExecuteNonQuery();
            cnn.Close();

            return data;
        }
        //execute scalar
        public object ExecuteScalar(string query, object[] para = null)
        {
            object data = 0;
            using (SqlConnection cnn = new SqlConnection(cntStr))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                string[] listpara = query.Split(' ');
                int i = 0;
                foreach(string item in listpara)
                    if(item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, para[i]);
                        i++;
                    }
                data = cmd.ExecuteScalar();
                cnn.Close();
            }

                return data;
        }
        public SqlDataReader ExecuteReader(string query)
        {
            SqlConnection cnn = new SqlConnection(cntStr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            cnn.Close();
            return reader;
        }
    }
}
