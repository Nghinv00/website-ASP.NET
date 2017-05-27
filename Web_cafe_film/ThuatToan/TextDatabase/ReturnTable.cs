using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web_cafe_film.ThuatToan.TextDatabase
{
    public class ReturnTable
    {
        DBConnection db;
        //  string chuoi = "";
        DataTable table;
        SqlDataAdapter adapter;
        SqlConnection con;
        SqlCommand command;
        ThuatToan.Data.Bang1 b1;
        public ReturnTable()
        {
            db = new DBConnection();            
        }    
        // Nhận đầu vào là chuỗi kết nối và trả về là 1 bảng dữ liệu..
        public DataTable getListMovieSugget(string s)
        {
            try
            {
                //con.Open();
                con = db.getConnection();
                adapter= new SqlDataAdapter(s, con);
                con.Open();
                table = new DataTable();             
                adapter.Fill(table);               
            }
             catch ( Exception ex)
            {

            }
            finally
            {
                adapter.Dispose();
                con.Close();
            }            
            return table;
        }

        public DataTable getMovieID(string s)
        {
            try
            {
                //con.Open();
                con = db.getConnection();
                adapter = new SqlDataAdapter(s, con);
                con.Open();
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                adapter.Dispose();
                con.Close();
            }
            return table;

        }

        public void UpdateTable(ThuatToan.Data.Bang1 b1, string chuoi)
        {
           //  String sql = "prd_Bang1_Update";
            try
            {                
                con = db.getConnection();
                command = new SqlCommand(chuoi, con);
                con.Open();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@A", SqlDbType.Int).Value = b1.A1;            
                command.Parameters.Add("@B", SqlDbType.Int).Value = b1.B1;                
                command.Parameters.Add("@C", SqlDbType.Int).Value = b1.C1;                
                command.Parameters.Add("@D", SqlDbType.Int).Value = b1.D1;              
                command.Parameters.Add("@E", SqlDbType.Int).Value = b1.E1;
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                adapter.Dispose();
                con.Close();
            }           
        }
        
    }
}