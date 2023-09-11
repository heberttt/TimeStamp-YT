using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeStamp
{
    public partial class addVideo : Form
    {
        video Video = new video();
        

        public addVideo()
        {
            InitializeComponent();
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            //add the wrangled pure youtube link to link
            //get title from youtube api
            //get stamp
            string link;
            link = (textBoxLink.Text).Trim();
            string title = (textBoxTitle.Text).Trim();
            string[] seperator = { "?t=" };

            if (link.Contains("?t="))
            {
                string[] linkNtime = link.Split(seperator, System.StringSplitOptions.RemoveEmptyEntries);
                int time = int.Parse(linkNtime[1]);
                link = linkNtime[0];

                string timeString = secondsToStamp(time);

                string coreLink = linkWrangle2(link);


                Video.Title = title;
                Video.Link = coreLink;
                Video.Stamp = timeString;

                Video.uploadSQL();

                MessageBox.Show("Uploaded to database");

                textBoxLink.Clear();
                textBoxTitle.Clear();


                //push to sql
                //make second to stamp function
            }
            else
            {
                string coreLink = linkWrangle(link);

                Video.Title = (textBoxTitle.Text).Trim();
                Video.Link = coreLink;
                Video.Stamp = "00:00";

                Video.uploadSQL();

                MessageBox.Show("Uploaded to database");

                textBoxLink.Clear();
                textBoxTitle.Clear();
            }




        }

        public string secondsToStamp(int seconds)
        {
            int hours = 0;
            int minutes = 0;
            int second = 0;

            while (seconds > 59)
            {
                seconds -= 60;
                minutes ++;

            }
            second = seconds;
            while (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }

            string final = "";

            if (hours > 0)
            {
                if (hours < 9)
                {
                    final += "0" + hours.ToString() + ":";
                }
                else
                {
                    final += hours.ToString() + ":";
                }
            }

            if (minutes > 0)
            {
                if (minutes < 9)
                {
                    final += "0" + minutes.ToString();
                }
                else
                {
                    final += minutes.ToString();
                }
            }
            else
            {
                final += "00";
            }

            final += ":";

            if (seconds < 9)
            {
                final += "0" + second.ToString();
            }
            else
            {
                final += second.ToString();
            }


            return final;
        }

        public string linkWrangle(string link)
        {
            string[] seperators = {"https://www.youtube.com/watch?v="};
            string[] linkArray = link.Split(seperators, System.StringSplitOptions.RemoveEmptyEntries);



            string formattedLink = linkArray[0];

            

            return formattedLink;
        }
        public string linkWrangle2(string link)
        {
            string[] seperators = { "https://youtu.be/" };
            string[] linkArray = link.Split(seperators, System.StringSplitOptions.RemoveEmptyEntries);



            string formattedLink = linkArray[0];



            return formattedLink;
        }




        private void addVideo_Load(object sender, EventArgs e)
        {

        }
    }
}
