namespace Spartan_Corner__1._1_
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.but_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.com_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_fname.Location = new System.Drawing.Point(59, 80);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(158, 26);
            this.txt_fname.TabIndex = 1;
            this.txt_fname.Text = "First Name";
            this.txt_fname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_fname_MouseClick);
            this.txt_fname.TextChanged += new System.EventHandler(this.txt_fname_TextChanged);
            // 
            // txt_last
            // 
            this.txt_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_last.Location = new System.Drawing.Point(241, 80);
            this.txt_last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(154, 26);
            this.txt_last.TabIndex = 2;
            this.txt_last.Text = "Last Name";
            this.txt_last.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_last_MouseClick);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_user.Location = new System.Drawing.Point(59, 123);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(336, 26);
            this.txt_user.TabIndex = 3;
            this.txt_user.Text = "User Name";
            this.txt_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_user_MouseClick);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_pass.Location = new System.Drawing.Point(59, 168);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(336, 26);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.Text = "Password";
            this.txt_pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_pass_MouseClick);
            // 
            // but_submit
            // 
            this.but_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.but_submit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_submit.Location = new System.Drawing.Point(138, 273);
            this.but_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_submit.Name = "but_submit";
            this.but_submit.Size = new System.Drawing.Size(181, 57);
            this.but_submit.TabIndex = 6;
            this.but_submit.Text = "Register";
            this.but_submit.UseVisualStyleBackColor = false;
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // com_type
            // 
            this.com_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_type.ForeColor = System.Drawing.SystemColors.GrayText;
            this.com_type.FormattingEnabled = true;
            this.com_type.Items.AddRange(new object[] {
            "student",
            "vendor"});
            this.com_type.Location = new System.Drawing.Point(59, 208);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(336, 28);
            this.com_type.TabIndex = 5;
            this.com_type.Text = "Registration Type";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 398);
            this.Controls.Add(this.com_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.txt_fname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button but_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_type;
    }
}