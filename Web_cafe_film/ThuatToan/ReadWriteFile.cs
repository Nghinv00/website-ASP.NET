using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;

namespace Web_cafe_film.ThuatToan
{
    public class ReadWriteFile
    {
        DBConnection db;
        SqlConnection con;
        Contracts.IApriori _apriori;
        public ReadWriteFile()
        {
            db = new DBConnection();
            var apriori = ContainerProvider.Container.GetExportedValue<Contracts.IApriori>();
            _apriori = apriori;
        }

        // Lấy danh sách các id của từng bộ phim và lưu vào 1 chuỗi : có kiểu dữ liệu là : IEnumerable
        // Đọc các mã phim tương ứng ứng item
        public IEnumerable<string> getItem()
        {
            string sql = "SELECT distinct MovieID FROM Movie";
            con = db.getConnection();
        
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
        
            string[] str = new string[dt.Rows.Count];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    str[i] = dt.Rows[i][0].ToString();                
            }                   
                                
            con.Close();
            return str.AsEnumerable();
        }

        //Đọc các transaction từ database :: Đọc Session trong database (DS các bộ phim người dùng đã xem)
        public string[] getTransactions()
        {
            string sql = "SELECT List FROM MovieSuggest";
            con = db.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            string[] str = new string[dt.Rows.Count];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    str[i] = dt.Rows[i][0].ToString();
            }
            con.Close();
            return str;
        }


        public void invokeApriori()
        {
            IEnumerable<string> items = getItem(); // Lấy danh sách các ID của từng phim và lưu vào biến items
            string[] trans = getTransactions(); // Lấy danh sách các session của từng người dùng và lưu vào biến transaction

            Implementation.Apriori algApr = new Implementation.Apriori();

            double minisup = 0.1;       //Độ hỗ trợ tối thiểu            
            // số lần xuát hiện bản ghi đó trên tổng số bản ghi

            double confident = 0.1;//  Độ tin cậy
            // độ tin cậy của khách hàng xe phim A sẽ xem phim B
            // Xác suất để 2 HĐ( 2 bộ phim ) cùng xuất hiện

            Entities.Output output = _apriori.ProcessTransaction(minisup, confident, items, trans);
            IList<ThuatToan.Entities.Rule> strongRule = output.StrongRules;                             
            GlobalVariables.suggest = strongRule.OrderBy(o => o.X).ThenBy(o => o.Confidence).ToList();  
        }

        public void getIDSuggest(string MovieID)
        {
            IList<ThuatToan.Entities.Rule> tmpSuggest = GlobalVariables.suggest;
            tmpSuggest = tmpSuggest.Where(o => o.X == MovieID).ToList();
            tmpSuggest = tmpSuggest.OrderBy(o => o.Confidence).ToList();
            string[] IDsug = new string[tmpSuggest.Count];
           
        }
       
    }
}