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
    public partial class editTime : Form
    {
        string initialTime;
        string initialTitle;

        video Video = new video();
        public editTime(string firstTime , string titlee)
        {
            initialTime = firstTime;
            initialTitle = titlee;
            InitializeComponent();
        }

        private void editTime_Load(object sender, EventArgs e)
        {
            textBoxTime.Text = initialTime;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Video.updateTimeStamp(textBoxTime.Text, initialTitle);
            MessageBox.Show("Time Updated");
        }
    }
}
