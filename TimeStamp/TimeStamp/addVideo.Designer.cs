namespace TimeStamp
{
    partial class addVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11F);
            this.label3.Location = new System.Drawing.Point(157, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(323, 202);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(625, 31);
            this.textBoxLink.TabIndex = 3;
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(381, 291);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(280, 53);
            this.btnAddLink.TabIndex = 4;
            this.btnAddLink.Text = "Add ";
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F);
            this.label2.Location = new System.Drawing.Point(157, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(323, 119);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(625, 31);
            this.textBoxTitle.TabIndex = 6;
            // 
            // addVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 383);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addVideo";
            this.Text = "addVideo";
            this.Load += new System.EventHandler(this.addVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}