namespace TimeStamp
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimeStamp = new System.Windows.Forms.Label();
            this.listBoxTimeStamps = new System.Windows.Forms.ListBox();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.btnEditTime = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxTitle = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSize = true;
            this.TimeStamp.Font = new System.Drawing.Font("Centaur", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStamp.Location = new System.Drawing.Point(12, 9);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Size = new System.Drawing.Size(282, 66);
            this.TimeStamp.TabIndex = 0;
            this.TimeStamp.Text = "TimeStamp";
            // 
            // listBoxTimeStamps
            // 
            this.listBoxTimeStamps.FormattingEnabled = true;
            this.listBoxTimeStamps.ItemHeight = 25;
            this.listBoxTimeStamps.Location = new System.Drawing.Point(1163, 181);
            this.listBoxTimeStamps.Name = "listBoxTimeStamps";
            this.listBoxTimeStamps.Size = new System.Drawing.Size(273, 554);
            this.listBoxTimeStamps.TabIndex = 1;
            this.listBoxTimeStamps.SelectedIndexChanged += new System.EventHandler(this.listBoxTimeStamps_SelectedIndexChanged);
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Location = new System.Drawing.Point(293, 759);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new System.Drawing.Size(358, 69);
            this.btnOpenLink.TabIndex = 2;
            this.btnOpenLink.Text = "Copy link";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            this.btnOpenLink.Click += new System.EventHandler(this.btnOpenLink_Click);
            // 
            // btnEditTime
            // 
            this.btnEditTime.Location = new System.Drawing.Point(884, 759);
            this.btnEditTime.Name = "btnEditTime";
            this.btnEditTime.Size = new System.Drawing.Size(358, 69);
            this.btnEditTime.TabIndex = 3;
            this.btnEditTime.Text = "Edit time";
            this.btnEditTime.UseVisualStyleBackColor = true;
            this.btnEditTime.Click += new System.EventHandler(this.btnEditTime_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(554, 85);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(268, 67);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(884, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(268, 67);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1201, 85);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(268, 67);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBoxTitle
            // 
            this.listBoxTitle.FormattingEnabled = true;
            this.listBoxTitle.ItemHeight = 25;
            this.listBoxTitle.Location = new System.Drawing.Point(84, 181);
            this.listBoxTitle.Name = "listBoxTitle";
            this.listBoxTitle.Size = new System.Drawing.Size(1049, 554);
            this.listBoxTitle.TabIndex = 7;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 881);
            this.Controls.Add(this.listBoxTitle);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditTime);
            this.Controls.Add(this.btnOpenLink);
            this.Controls.Add(this.listBoxTimeStamps);
            this.Controls.Add(this.TimeStamp);
            this.Name = "mainMenu";
            this.Text = "TimeStamp";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeStamp;
        private System.Windows.Forms.ListBox listBoxTimeStamps;
        private System.Windows.Forms.Button btnOpenLink;
        private System.Windows.Forms.Button btnEditTime;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxTitle;
    }
}