namespace Spartan_Corner__1._1_
{
    partial class IssueReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueReports));
            this.but_clear = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_retrieve = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.txt_issue = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.txt_issueDate = new System.Windows.Forms.TextBox();
            this.txt_currentDate = new System.Windows.Forms.TextBox();
            this.lab_issue = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_fullName = new System.Windows.Forms.Label();
            this.lab_issueDate = new System.Windows.Forms.Label();
            this.lab_currentDate = new System.Windows.Forms.Label();
            this.lab_resolved = new System.Windows.Forms.Label();
            this.appDatabaseDataSet1 = new Spartan_Corner__1._1_.AppDatabaseDataSet1();
            this.contactUsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactUsTableAdapter = new Spartan_Corner__1._1_.AppDatabaseDataSet1TableAdapters.ContactUsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_resolved = new System.Windows.Forms.ComboBox();
            this.but_Menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_contactUs = new System.Windows.Forms.DataGridView();
            this.contactUsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDatabaseDataSet3 = new Spartan_Corner__1._1_.AppDatabaseDataSet3();
            this.contactUsTableAdapter1 = new Spartan_Corner__1._1_.AppDatabaseDataSet3TableAdapters.ContactUsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactUsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactUsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.DimGray;
            this.but_clear.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_clear.Location = new System.Drawing.Point(216, 388);
            this.but_clear.Margin = new System.Windows.Forms.Padding(4);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(91, 37);
            this.but_clear.TabIndex = 1;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.DimGray;
            this.but_delete.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_delete.Location = new System.Drawing.Point(95, 388);
            this.but_delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(91, 37);
            this.but_delete.TabIndex = 0;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_update
            // 
            this.but_update.BackColor = System.Drawing.Color.DimGray;
            this.but_update.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_update.Location = new System.Drawing.Point(268, 349);
            this.but_update.Margin = new System.Windows.Forms.Padding(4);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(95, 34);
            this.but_update.TabIndex = 16;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_retrieve
            // 
            this.but_retrieve.BackColor = System.Drawing.Color.DimGray;
            this.but_retrieve.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_retrieve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_retrieve.Location = new System.Drawing.Point(141, 349);
            this.but_retrieve.Margin = new System.Windows.Forms.Padding(4);
            this.but_retrieve.Name = "but_retrieve";
            this.but_retrieve.Size = new System.Drawing.Size(119, 34);
            this.but_retrieve.TabIndex = 15;
            this.but_retrieve.Text = "Retrieve";
            this.but_retrieve.UseVisualStyleBackColor = false;
            this.but_retrieve.Click += new System.EventHandler(this.but_retrieve_Click);
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.DimGray;
            this.but_add.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_add.Location = new System.Drawing.Point(32, 349);
            this.but_add.Margin = new System.Windows.Forms.Padding(4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(99, 34);
            this.but_add.TabIndex = 14;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // txt_issue
            // 
            this.txt_issue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_issue.Location = new System.Drawing.Point(156, 194);
            this.txt_issue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_issue.Multiline = true;
            this.txt_issue.Name = "txt_issue";
            this.txt_issue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_issue.Size = new System.Drawing.Size(225, 69);
            this.txt_issue.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(156, 144);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(225, 30);
            this.txt_email.TabIndex = 11;
            // 
            // txt_fullName
            // 
            this.txt_fullName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullName.Location = new System.Drawing.Point(156, 101);
            this.txt_fullName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(225, 30);
            this.txt_fullName.TabIndex = 10;
            // 
            // txt_issueDate
            // 
            this.txt_issueDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_issueDate.Location = new System.Drawing.Point(156, 47);
            this.txt_issueDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_issueDate.Name = "txt_issueDate";
            this.txt_issueDate.Size = new System.Drawing.Size(225, 30);
            this.txt_issueDate.TabIndex = 9;
            // 
            // txt_currentDate
            // 
            this.txt_currentDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentDate.Location = new System.Drawing.Point(156, 7);
            this.txt_currentDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_currentDate.Name = "txt_currentDate";
            this.txt_currentDate.Size = new System.Drawing.Size(225, 30);
            this.txt_currentDate.TabIndex = 8;
            // 
            // lab_issue
            // 
            this.lab_issue.AutoSize = true;
            this.lab_issue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_issue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_issue.Location = new System.Drawing.Point(72, 191);
            this.lab_issue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_issue.Name = "lab_issue";
            this.lab_issue.Size = new System.Drawing.Size(59, 35);
            this.lab_issue.TabIndex = 7;
            this.lab_issue.Text = "Issue";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_email.Location = new System.Drawing.Point(58, 141);
            this.lab_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(73, 35);
            this.lab_email.TabIndex = 6;
            this.lab_email.Text = "Email";
            // 
            // lab_fullName
            // 
            this.lab_fullName.AutoSize = true;
            this.lab_fullName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_fullName.Location = new System.Drawing.Point(14, 98);
            this.lab_fullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_fullName.Name = "lab_fullName";
            this.lab_fullName.Size = new System.Drawing.Size(117, 35);
            this.lab_fullName.TabIndex = 5;
            this.lab_fullName.Text = "Full Name";
            // 
            // lab_issueDate
            // 
            this.lab_issueDate.AutoSize = true;
            this.lab_issueDate.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_issueDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_issueDate.Location = new System.Drawing.Point(14, 47);
            this.lab_issueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_issueDate.Name = "lab_issueDate";
            this.lab_issueDate.Size = new System.Drawing.Size(114, 35);
            this.lab_issueDate.TabIndex = 4;
            this.lab_issueDate.Text = "Issue Date";
            // 
            // lab_currentDate
            // 
            this.lab_currentDate.AutoSize = true;
            this.lab_currentDate.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_currentDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_currentDate.Location = new System.Drawing.Point(-1, 7);
            this.lab_currentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_currentDate.Name = "lab_currentDate";
            this.lab_currentDate.Size = new System.Drawing.Size(148, 35);
            this.lab_currentDate.TabIndex = 3;
            this.lab_currentDate.Text = "Current Date";
            // 
            // lab_resolved
            // 
            this.lab_resolved.AutoSize = true;
            this.lab_resolved.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_resolved.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_resolved.Location = new System.Drawing.Point(29, 268);
            this.lab_resolved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_resolved.Name = "lab_resolved";
            this.lab_resolved.Size = new System.Drawing.Size(99, 35);
            this.lab_resolved.TabIndex = 52;
            this.lab_resolved.Text = "Resolved";
            // 
            // appDatabaseDataSet1
            // 
            this.appDatabaseDataSet1.DataSetName = "AppDatabaseDataSet1";
            this.appDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactUsBindingSource
            // 
            this.contactUsBindingSource.DataMember = "ContactUs";
            this.contactUsBindingSource.DataSource = this.appDatabaseDataSet1;
            // 
            // contactUsTableAdapter
            // 
            this.contactUsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.txt_resolved);
            this.panel1.Controls.Add(this.but_Menu);
            this.panel1.Controls.Add(this.lab_currentDate);
            this.panel1.Controls.Add(this.lab_issueDate);
            this.panel1.Controls.Add(this.lab_resolved);
            this.panel1.Controls.Add(this.lab_fullName);
            this.panel1.Controls.Add(this.but_clear);
            this.panel1.Controls.Add(this.lab_email);
            this.panel1.Controls.Add(this.but_delete);
            this.panel1.Controls.Add(this.lab_issue);
            this.panel1.Controls.Add(this.but_update);
            this.panel1.Controls.Add(this.txt_currentDate);
            this.panel1.Controls.Add(this.but_retrieve);
            this.panel1.Controls.Add(this.txt_issueDate);
            this.panel1.Controls.Add(this.but_add);
            this.panel1.Controls.Add(this.txt_fullName);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_issue);
            this.panel1.Location = new System.Drawing.Point(15, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 501);
            this.panel1.TabIndex = 56;
            // 
            // txt_resolved
            // 
            this.txt_resolved.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resolved.FormattingEnabled = true;
            this.txt_resolved.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Other:"});
            this.txt_resolved.Location = new System.Drawing.Point(156, 270);
            this.txt_resolved.Name = "txt_resolved";
            this.txt_resolved.Size = new System.Drawing.Size(225, 32);
            this.txt_resolved.TabIndex = 53;
            // 
            // but_Menu
            // 
            this.but_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_Menu.BackgroundImage")));
            this.but_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.but_Menu.Location = new System.Drawing.Point(5, 424);
            this.but_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Menu.Name = "but_Menu";
            this.but_Menu.Size = new System.Drawing.Size(67, 58);
            this.but_Menu.TabIndex = 3;
            this.but_Menu.UseVisualStyleBackColor = true;
            this.but_Menu.Click += new System.EventHandler(this.but_Menu_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_contactUs
            // 
            this.dgv_contactUs.AutoGenerateColumns = false;
            this.dgv_contactUs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(120)))));
            this.dgv_contactUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contactUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.currentDateDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.problemDataGridViewTextBoxColumn,
            this.resolvedDataGridViewTextBoxColumn});
            this.dgv_contactUs.DataSource = this.contactUsBindingSource1;
            this.dgv_contactUs.Location = new System.Drawing.Point(4, 13);
            this.dgv_contactUs.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_contactUs.Name = "dgv_contactUs";
            this.dgv_contactUs.Size = new System.Drawing.Size(995, 515);
            this.dgv_contactUs.TabIndex = 57;
            this.dgv_contactUs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_contactUs_MouseClick);
            // 
            // contactUsBindingSource1
            // 
            this.contactUsBindingSource1.DataMember = "ContactUs";
            this.contactUsBindingSource1.DataSource = this.appDatabaseDataSet3;
            // 
            // appDatabaseDataSet3
            // 
            this.appDatabaseDataSet3.DataSetName = "AppDatabaseDataSet3";
            this.appDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactUsTableAdapter1
            // 
            this.contactUsTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.dgv_contactUs);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(413, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 535);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 15;
            // 
            // currentDateDataGridViewTextBoxColumn
            // 
            this.currentDateDataGridViewTextBoxColumn.DataPropertyName = "CurrentDate";
            this.currentDateDataGridViewTextBoxColumn.HeaderText = "CurrentDate";
            this.currentDateDataGridViewTextBoxColumn.Name = "currentDateDataGridViewTextBoxColumn";
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // problemDataGridViewTextBoxColumn
            // 
            this.problemDataGridViewTextBoxColumn.DataPropertyName = "Problem";
            this.problemDataGridViewTextBoxColumn.HeaderText = "Problem";
            this.problemDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.problemDataGridViewTextBoxColumn.Name = "problemDataGridViewTextBoxColumn";
            // 
            // resolvedDataGridViewTextBoxColumn
            // 
            this.resolvedDataGridViewTextBoxColumn.DataPropertyName = "Resolved";
            this.resolvedDataGridViewTextBoxColumn.HeaderText = "Resolved";
            this.resolvedDataGridViewTextBoxColumn.Name = "resolvedDataGridViewTextBoxColumn";
            // 
            // IssueReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1414, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IssueReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Reports";
            this.Load += new System.EventHandler(this.IssueReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactUsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contactUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactUsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_retrieve;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.TextBox txt_issue;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.TextBox txt_issueDate;
        private System.Windows.Forms.TextBox txt_currentDate;
        private System.Windows.Forms.Label lab_issue;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_fullName;
        private System.Windows.Forms.Label lab_issueDate;
        private System.Windows.Forms.Label lab_currentDate;
        private System.Windows.Forms.Label lab_resolved;
        private AppDatabaseDataSet1 appDatabaseDataSet1;
        private System.Windows.Forms.BindingSource contactUsBindingSource;
        private AppDatabaseDataSet1TableAdapters.ContactUsTableAdapter contactUsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_Menu;
        private System.Windows.Forms.DataGridView dgv_contactUs;
        private AppDatabaseDataSet3 appDatabaseDataSet3;
        private System.Windows.Forms.BindingSource contactUsBindingSource1;
        private AppDatabaseDataSet3TableAdapters.ContactUsTableAdapter contactUsTableAdapter1;
        private System.Windows.Forms.ComboBox txt_resolved;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolvedDataGridViewTextBoxColumn;
    }
}