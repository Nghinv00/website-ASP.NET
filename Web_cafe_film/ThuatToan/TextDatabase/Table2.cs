using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Web_cafe_film.ThuatToan.TextDatabase
{
    public class Table2
    {
        ReturnTable ReturnTb;
        DataTable tableUpdate;
        DataTable list;
        DataTable tableMovieID = new DataTable();
        public ThuatToan.Data.Bang2 b2 = new Data.Bang2();

        string[] s;

        public Table2()
        {
            ReturnTb = new ReturnTable();
        }

        public void List_MovieSuggest2()
        {
            ReturnTb = new ReturnTable();

            string listSelect = "prd_Table1_Select";

            string sqlMovieId = "Select MovieID From Movie";

            list = ReturnTb.getListMovieSugget(listSelect);

            // Lấy về danh sách các movidID
            tableMovieID = ReturnTb.getMovieID(sqlMovieId);

            // Test dữ liệu xem có lấy được dữ liệu từ database hay không ? ??????
            string movieID0 = tableMovieID.Rows[0][0].ToString();
            string movieID1 = tableMovieID.Rows[1][0].ToString();
            string movieID2 = tableMovieID.Rows[2][0].ToString();
            string movieID3 = tableMovieID.Rows[3][0].ToString();
            string movieID4 = tableMovieID.Rows[4][0].ToString();
            
            string session1 = list.Rows[0][0].ToString();


            for( int i = 0; i < tableMovieID.Rows.Count; i++)
            {
                //string movieID000 = (tableMovieID.Rows[i][0].ToString()).Substring(0, 1);
                //string movieID01 = (tableMovieID.Rows[i][0].ToString()).Substring(1, 1);

                for( int j = 0; j < list.Rows.Count; j++)
                {
                    s = list.Rows[i][0].ToString().Split(';');

                    for (int k = 0; k < s.Count(); k++)
                    {
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID1.Equals(s[k]))
                                b2.Ab++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID2.Equals(s[k]))
                                b2.Ac++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Ad++;
                        }

                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID4.Equals(s[k]))
                                b2.Ae++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Bc++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Bd++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Be++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Cd++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.Ce++;
                        }
                        if (movieID0.Equals(s[k]))
                        {
                            if (movieID3.Equals(s[k]))
                                b2.De++;
                        }


                    }
                    
               }


           }



            }

            

        }
    
}