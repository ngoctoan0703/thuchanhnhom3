using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace làm_việc_nhóm_3
{
    internal class function

    {
        // kết nối dữ liệu
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ADMIN\\SQLEXPRESS01;Initial Catalog=QLikhachsan;Integrated Security=True";
            return con;
        }
        // lấy dữ liệu
        public DataSet GetData(String query)
        {
            // con mở kn đến cơ sở dữ liệu
            SqlConnection con = getConnection();
            // thực thi clệnh trên sql
            SqlCommand cmd = new SqlCommand();
            // gán conect cho đt cmd giúp cmd thực thi
            cmd.Connection = con;
            // lệnh sql đc thực thi 
            cmd.CommandText = query;
            // lấy data từ Dataset, nối csdl và ứng dụng 
            SqlDataAdapter da = new SqlDataAdapter();
            // lưu trữ csdl khi truy vấn, dtaset bộ nhớ tạm 
            DataSet ds = new DataSet();
            // thực thi và điền kq sau khi truy vấn
            da.Fill(ds);
            return ds;

        }
        // update dữ liệu
        public void setData(string query, string message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // mở csdl
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message);
        }
    }
}
