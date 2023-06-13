using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DataAccessLayer
    {
        private SqlConnection conn;

        public DataAccessLayer()
        {
            conn = new SqlConnection("Data Source=P1LLIER; Initial Catalog=Connect; Integrated Security=True");
        }

        public bool CheckLogin(string username, string password)
        {
            bool result = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.NGUOIDUNG WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau", conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", username);
            cmd.Parameters.AddWithValue("@MatKhau", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            conn.Close();
            return result;
        }
    }
}
