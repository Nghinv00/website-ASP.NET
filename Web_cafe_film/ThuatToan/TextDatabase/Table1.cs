using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Web_cafe_film.ThuatToan.Data;
namespace Web_cafe_film.ThuatToan.TextDatabase
{
    public class Table1
    {   
        ReturnTable ReturnTb;
        DataTable tableUpdate ;
        DataTable list = new DataTable();

        DataTable tableMovieID = new DataTable();


        public ThuatToan.Data.Bang1 b1 = new Bang1();

        string[] s;
       //  char a = '1', b = '2', c = '3', d = '4', e = '5';
        // string[] ListMovieID = new string[5] { "1","2","3","4","5" };
        // chuỗi đó là để t kiểm tra mà ( char a='A';)


        public Table1()
        {
            ReturnTb = new ReturnTable();
             // return ReturnTb;
        }
        

        public void List_MovieSuggest1()
        {
              // b1 = new Bang1();
             ReturnTb = new ReturnTable();
            // string listsession = "Select List From MovieSuggest"cái
            string listSelect = "prd_Table1_Select";

            string sqlmovieID = "Select MovieID From Movie";

            // Lấy thông tin view của các session 
            list = ReturnTb.getListMovieSugget(listSelect);

            tableMovieID = ReturnTb.getMovieID(sqlmovieID);

            // Test dữ liệu xem có lấy được dữ liệu từ database hay không ? 
                string movieID0 = tableMovieID.Rows[0][0].ToString();
                string movieID1 = tableMovieID.Rows[1][0].ToString();
                string movieID2 = tableMovieID.Rows[2][0].ToString();
                string movieID3 = tableMovieID.Rows[3][0].ToString();
                string movieID4 = tableMovieID.Rows[4][0].ToString();
               
                // Test dữ liệu xem có lấy được dữ liệu từ database hay không ? 
                string session1 = list.Rows[0][0].ToString();
                string session2 = list.Rows[1][0].ToString();
                string session3 = list.Rows[2][0].ToString();
                string session4 = list.Rows[3][0].ToString();
            
                //b1.A1 = 0;
                //b1.B1 = 0;
                //b1.C1 = 0;
                //b1.D1 = 0;
                //b1.E1 = 0;
            for (int i = 0; i < list.Rows.Count; i++)
            {
                s = list.Rows[i][0].ToString().Split(';');                

                
                  
                for ( int j = 0;j < s.Count(); j++)
                {
                    if (tableMovieID.Rows[0][0].ToString().Equals(s[j])) { b1.A1 = b1.A1 + 1; }
                    if (tableMovieID.Rows[1][0].ToString().Equals(s[j])) { b1.B1 = b1.B1 + 1; }
                    if (tableMovieID.Rows[2][0].ToString().Equals(s[j])) { b1.C1 = b1.C1 + 1; }
                    if (tableMovieID.Rows[3][0].ToString().Equals(s[j])) { b1.D1 = b1.D1 + 1; }
                    if (tableMovieID.Rows[4][0].ToString().Equals(s[j])) { b1.E1 = b1.E1 + 1; }

                    //if (movieID0.Equals(s[j])) { b1.A1 = b1.A1 + 1; }
                    //if (movieID1.Equals(s[j])) { b1.B1 = b1.B1 + 1; }
                    //if (movieID2.Equals(s[j])) { b1.C1 = b1.C1 + 1; }
                    //if (movieID3.Equals(s[j])) { b1.D1 = b1.D1 + 1; }
                    //if (movieID4.Equals(s[j])) { b1.E1 = b1.E1 + 1; }
                }
            }
           


            Update_Table();           
        }

     



        public void Update_Table()
        {
            
            //string updateTable1 = "Update Table1 set A = '" + b1.A1 + "', B = '" + b1.B1 + "', C = '"+
            //    b1.C1 + "', D = '" + b1.D1 + "', E = '" + b1.E1 + "'" ;

            string updateTable2 = "prd_Bang1_Update";
            ReturnTb.UpdateTable(b1, updateTable2);
        }





        // bỏ
        public void xuLuList()
        {
            for (int i = 0; i < list.Rows.Count; i++)
            {

                //list.Rows[i][0].ToString().Split(';');
                s = list.Rows[i][0].ToString().Split(';');

                //chuỗi lại trở về 123 ::: nếu so sánh 1 với 123 thì vẫn sẽ không được...
                //Giwof phải tạo ra 1 mảng để đưa dữ liệu vào thì mới so sánh dc
                // 
                // string[] arr = ((IEnumerable)list).Cast<object>().Select(x => x.ToString()).ToArray();


            }


        }


    }
}