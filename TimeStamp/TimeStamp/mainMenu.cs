using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TimeStamp
{
    public partial class mainMenu : Form
    {
        video Video = new video();
        public void loadDisplay()
        {
            listBoxTimeStamps.Items.Add("TimeStamp");
            listBoxTitle.Items.Add("Title");
            listBoxTitle.Items.Add("");
            listBoxTimeStamps.Items.Add("");

            int i = 0;
            
            ArrayList titleArray = new ArrayList();
            ArrayList stampArray = new ArrayList();

            titleArray = Video.viewTitle();
            stampArray = Video.viewStamp();

            foreach (var item in titleArray)
            {
                listBoxTimeStamps.Items.Add(stampArray[i]);
                listBoxTitle.Items.Add(titleArray[i]);

                i++;
            }

        }
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            loadDisplay();
        }

        private void listBoxTimeStamps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBoxTimeStamps.Items.Clear();
            listBoxTitle.Items.Clear();
            loadDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addVideo AddVideo = new addVideo();
            AddVideo.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedText;
            
            selectedText = listBoxTitle.SelectedItem.ToString();

            if (selectedText == "")
            {
                MessageBox.Show("Select a title");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \"" + selectedText + "\"", "TimeStamp deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Video.DeleteVideo(selectedText);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
            }
        }

        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            string selectedText = listBoxTitle.SelectedItem.ToString();

            string realLink;

            realLink = Video.copyLink(selectedText);

            Clipboard.SetText(realLink, TextDataFormat.Text);

            MessageBox.Show("\"" + selectedText + "\"" + " has been copied");
        }

        private void btnEditTime_Click(object sender, EventArgs e)
        {
            string selectedText;

            selectedText= listBoxTitle.SelectedItem.ToString();

            if (selectedText == "")
            {
                MessageBox.Show("Select a title");
            }
            else
            {
                string theStamp = Video.copyStamps(selectedText);

                editTime update = new editTime(theStamp, selectedText);

                update.Show();
            }

            
        }
    }
}
