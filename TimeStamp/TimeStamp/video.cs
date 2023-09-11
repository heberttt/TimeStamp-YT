using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace TimeStamp
{
    internal class video
    {
        private string title;
        private string stamp;
        private string link;

        static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public video()
        {

        }
        
        public video(string title, string stamp, string link)
        {
            this.title = title;
            this.stamp = stamp;
            this.link = link;
        }


        public string Title
        {
            get { return title; }
            set { title = value; }
        }



        public string Stamp
        {
            get { return stamp; }
            set
            {
                stamp = value;
            }
        }

        public string Link
        {
            get { return link; }
            set
            {
                link = value;
            }
        }


        public void uploadSQL()
        {
            connection.Open();
            SqlCommand sql = new SqlCommand("insert into videoDetials (title, stamp, link) values (@titlee, @stampp, @linkk)", connection);
            sql.Parameters.AddWithValue("@titlee", Title);
            sql.Parameters.AddWithValue("@stampp", Stamp);
            sql.Parameters.AddWithValue("@linkk", Link);
            sql.ExecuteNonQuery();
            connection.Close();



        }


        public ArrayList viewTitle()
        {
            ArrayList titleList = new ArrayList();


            connection.Open();
            SqlCommand sql = new SqlCommand("select title from videoDetials", connection);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            while (sqlDataReader.Read())
            {
                titleList.Add(sqlDataReader.GetString(0));
            }

            connection.Close();

            return titleList;
        }

        public ArrayList viewStamp()
        {
            ArrayList stampList = new ArrayList();

            connection.Open();
            SqlCommand sql2 = new SqlCommand("select stamp from videoDetials", connection);
            SqlDataReader sqlDataReader2 = sql2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                stampList.Add(sqlDataReader2.GetString(0));
            }
            connection.Close();

            return stampList;
        }

        public ArrayList viewLink()
        {
            ArrayList linkList = new ArrayList();
            connection.Open();
            SqlCommand sql3 = new SqlCommand("select link from videoDetials", connection);
            SqlDataReader sqlDataReader3 = sql3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                linkList.Add(sqlDataReader3.GetString(0));
            }
            connection.Close();

            return linkList;
        }

        public void DeleteVideo(string delTitle)
        {
            connection.Open();

            SqlCommand sql = new SqlCommand("DELETE FROM videoDetials WHERE title = @titlee", connection);

            sql.Parameters.AddWithValue("@titlee", delTitle);

            sql.ExecuteNonQuery();
            
            connection.Close();

            MessageBox.Show("TimeStamp Deleted");

        }

        public string copyLink (string copyTitle)
        {

            connection.Open();

            SqlCommand sql = new SqlCommand("Select link from videoDetials where title = @titlee", connection);

            sql.Parameters.AddWithValue("@titlee", copyTitle);

            string copiedLink = sql.ExecuteScalar().ToString();

            connection.Close();

            connection.Open();

            SqlCommand sql2 = new SqlCommand("Select stamp from videoDetials where link = @linkk", connection);

            sql2.Parameters.AddWithValue("@linkk", copiedLink);

            string copiedStamp = sql2.ExecuteScalar().ToString();

            connection.Close();



            string finalLink = "https://youtu.be/" + copiedLink + "?t=" + stampToSeconds(copiedStamp).ToString();


            return finalLink;
        }

        public string copyStamps(string copyTitle)
        {
            connection.Open();

            SqlCommand sql2 = new SqlCommand("Select stamp from videoDetials where title = @titlee", connection);

            sql2.Parameters.AddWithValue("@titlee", copyTitle);

            string copiedStamp = sql2.ExecuteScalar().ToString();

            connection.Close();

            return copiedStamp;
        }

        public int stampToSeconds(string stampp)
        {
            string[] timeArray = stampp.Split(':');

            int totalSeconds = 0;

            if (timeArray.Length == 3 ) {

                totalSeconds += int.Parse(timeArray[0]) * 3600;
                totalSeconds += int.Parse(timeArray[1]) * 60;
                totalSeconds += int.Parse(timeArray[2]);

            }
            else
            {
                totalSeconds += int.Parse(timeArray[0]) * 60;
                totalSeconds += int.Parse(timeArray[1]);
            }

            return totalSeconds;
        }

        public void updateTimeStamp(string theTime, string theTitle)
        {
            theTime = theTime.Trim();

            string[] fixTimeArray = theTime.Split(':');

            if (fixTimeArray[0].Length < 2 ) {

                theTime = "0" + theTime;
            
            }


            connection.Open();
            SqlCommand sql = new SqlCommand("UPDATE videoDetials SET stamp = @stampp where title = @titlee ", connection);
            sql.Parameters.AddWithValue ("@stampp", theTime);
            sql.Parameters.AddWithValue("@titlee", theTitle);
            sql.ExecuteNonQuery();
            connection.Close();
        }

    }
}
