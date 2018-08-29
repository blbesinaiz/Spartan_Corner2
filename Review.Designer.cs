namespace Spartan_Corner__1._1_
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.txt_screenName = new System.Windows.Forms.TextBox();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.but_submit = new System.Windows.Forms.Button();
            this.com_rate = new System.Windows.Forms.ComboBox();
            this.com_vendorTitle = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_screenName
            // 
            this.txt_screenName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_screenName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_screenName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_screenName.Location = new System.Drawing.Point(157, 32);
            this.txt_screenName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_screenName.Name = "txt_screenName";
            this.txt_screenName.Size = new System.Drawing.Size(319, 30);
            this.txt_screenName.TabIndex = 1;
            this.txt_screenName.TextChanged += new System.EventHandler(this.txt_screenName_TextChanged);
            // 
            // txt_review
            // 
            this.txt_review.BackColor = System.Drawing.SystemColors.Control;
            this.txt_review.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_review.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_review.Location = new System.Drawing.Point(157, 185);
            this.txt_review.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_review.Multiline = true;
            this.txt_review.Name = "txt_review";
            this.txt_review.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_review.Size = new System.Drawing.Size(319, 149);
            this.txt_review.TabIndex = 4;
            // 
            // but_submit
            // 
            this.but_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_submit.BackgroundImage")));
            this.but_submit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_submit.Location = new System.Drawing.Point(253, 357);
            this.but_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_submit.Name = "but_submit";
            this.but_submit.Size = new System.Drawing.Size(108, 53);
            this.but_submit.TabIndex = 5;
            this.but_submit.Text = "Submit";
            this.but_submit.UseVisualStyleBackColor = true;
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // com_rate
            // 
            this.com_rate.BackColor = System.Drawing.SystemColors.Control;
            this.com_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_rate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_rate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.com_rate.FormattingEnabled = true;
            this.com_rate.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.com_rate.Location = new System.Drawing.Point(157, 135);
            this.com_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_rate.Name = "com_rate";
            this.com_rate.Size = new System.Drawing.Size(319, 32);
            this.com_rate.TabIndex = 3;
            // 
            // com_vendorTitle
            // 
            this.com_vendorTitle.BackColor = System.Drawing.SystemColors.Control;
            this.com_vendorTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_vendorTitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_vendorTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.com_vendorTitle.FormattingEnabled = true;
            this.com_vendorTitle.Location = new System.Drawing.Point(157, 82);
            this.com_vendorTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_vendorTitle.Name = "com_vendorTitle";
            this.com_vendorTitle.Size = new System.Drawing.Size(319, 32);
            this.com_vendorTitle.TabIndex = 2;
            this.com_vendorTitle.SelectedIndexChanged += new System.EventHandler(this.com_vendorTitle_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.com_vendorTitle);
            this.panel2.Controls.Add(this.com_rate);
            this.panel2.Controls.Add(this.but_submit);
            this.panel2.Controls.Add(this.txt_review);
            this.panel2.Controls.Add(this.txt_screenName);
            this.panel2.Location = new System.Drawing.Point(108, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 432);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rating:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vendor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // but_back
            // 
            this.but_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_back.BackgroundImage")));
            this.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_back.Location = new System.Drawing.Point(0, 567);
            this.but_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(137, 42);
            this.but_back.TabIndex = 14;
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(108, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 69);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(27, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(481, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please fill out the form below to rate a vendor";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate";
            this.Load += new System.EventHandler(this.Review_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_screenName;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.Button but_submit;
        private System.Windows.Forms.ComboBox com_rate;
        private System.Windows.Forms.ComboBox com_vendorTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}