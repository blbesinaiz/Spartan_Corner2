namespace Spartan_Corner__1._1_
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.logInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDatabaseDataSet = new Spartan_Corner__1._1_.AppDatabaseDataSet();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_retrieve = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lab_privilege = new System.Windows.Forms.Label();
            this.lab_pass = new System.Windows.Forms.Label();
            this.lab_userName = new System.Windows.Forms.Label();
            this.lab_lastName = new System.Windows.Forms.Label();
            this.lab_firstName = new System.Windows.Forms.Label();
            this.logInTableAdapter = new Spartan_Corner__1._1_.AppDatabaseDataSetTableAdapters.LogInTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_privilege = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_Menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInBindingSource
            // 
            this.logInBindingSource.DataMember = "LogIn";
            this.logInBindingSource.DataSource = this.appDatabaseDataSet;
            // 
            // appDatabaseDataSet
            // 
            this.appDatabaseDataSet.DataSetName = "AppDatabaseDataSet";
            this.appDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.DimGray;
            this.but_clear.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_clear.Location = new System.Drawing.Point(147, 362);
            this.but_clear.Margin = new System.Windows.Forms.Padding(4);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(89, 34);
            this.but_clear.TabIndex = 14;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.DimGray;
            this.but_delete.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_delete.Location = new System.Drawing.Point(211, 318);
            this.but_delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(107, 36);
            this.but_delete.TabIndex = 13;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_update
            // 
            this.but_update.BackColor = System.Drawing.Color.DimGray;
            this.but_update.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_update.Location = new System.Drawing.Point(64, 318);
            this.but_update.Margin = new System.Windows.Forms.Padding(4);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(104, 36);
            this.but_update.TabIndex = 12;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_retrieve
            // 
            this.but_retrieve.BackColor = System.Drawing.Color.DimGray;
            this.but_retrieve.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_retrieve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_retrieve.Location = new System.Drawing.Point(211, 267);
            this.but_retrieve.Margin = new System.Windows.Forms.Padding(4);
            this.but_retrieve.Name = "but_retrieve";
            this.but_retrieve.Size = new System.Drawing.Size(107, 43);
            this.but_retrieve.TabIndex = 11;
            this.but_retrieve.Text = "Retrieve";
            this.but_retrieve.UseVisualStyleBackColor = false;
            this.but_retrieve.Click += new System.EventHandler(this.but_retrieve_Click);
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.DimGray;
            this.but_add.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_add.Location = new System.Drawing.Point(64, 267);
            this.but_add.Margin = new System.Windows.Forms.Padding(4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(104, 43);
            this.but_add.TabIndex = 10;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_pass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(124, 149);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(207, 30);
            this.txt_pass.TabIndex = 8;
            // 
            // txt_userName
            // 
            this.txt_userName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_userName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(124, 106);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(207, 30);
            this.txt_userName.TabIndex = 7;
            // 
            // txt_lastName
            // 
            this.txt_lastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_lastName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(124, 62);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(207, 30);
            this.txt_lastName.TabIndex = 6;
            // 
            // txt_firstName
            // 
            this.txt_firstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_firstName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(124, 15);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(207, 30);
            this.txt_firstName.TabIndex = 5;
            // 
            // lab_privilege
            // 
            this.lab_privilege.AutoSize = true;
            this.lab_privilege.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_privilege.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_privilege.Location = new System.Drawing.Point(-3, 188);
            this.lab_privilege.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_privilege.Name = "lab_privilege";
            this.lab_privilege.Size = new System.Drawing.Size(94, 33);
            this.lab_privilege.TabIndex = 4;
            this.lab_privilege.Text = "Privilege";
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_pass.Location = new System.Drawing.Point(-2, 154);
            this.lab_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(106, 33);
            this.lab_pass.TabIndex = 3;
            this.lab_pass.Text = "Password";
            // 
            // lab_userName
            // 
            this.lab_userName.AutoSize = true;
            this.lab_userName.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_userName.Location = new System.Drawing.Point(-2, 111);
            this.lab_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_userName.Name = "lab_userName";
            this.lab_userName.Size = new System.Drawing.Size(113, 33);
            this.lab_userName.TabIndex = 2;
            this.lab_userName.Text = "UserName";
            // 
            // lab_lastName
            // 
            this.lab_lastName.AutoSize = true;
            this.lab_lastName.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_lastName.Location = new System.Drawing.Point(-2, 66);
            this.lab_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_lastName.Name = "lab_lastName";
            this.lab_lastName.Size = new System.Drawing.Size(118, 33);
            this.lab_lastName.TabIndex = 1;
            this.lab_lastName.Text = "Last Name";
            // 
            // lab_firstName
            // 
            this.lab_firstName.AutoSize = true;
            this.lab_firstName.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_firstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_firstName.Location = new System.Drawing.Point(-2, 20);
            this.lab_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_firstName.Name = "lab_firstName";
            this.lab_firstName.Size = new System.Drawing.Size(121, 33);
            this.lab_firstName.TabIndex = 0;
            this.lab_firstName.Text = "First Name";
            // 
            // logInTableAdapter
            // 
            this.logInTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.txt_privilege);
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.but_clear);
            this.panel2.Controls.Add(this.txt_userName);
            this.panel2.Controls.Add(this.lab_firstName);
            this.panel2.Controls.Add(this.txt_lastName);
            this.panel2.Controls.Add(this.but_delete);
            this.panel2.Controls.Add(this.txt_firstName);
            this.panel2.Controls.Add(this.lab_lastName);
            this.panel2.Controls.Add(this.lab_privilege);
            this.panel2.Controls.Add(this.but_update);
            this.panel2.Controls.Add(this.but_add);
            this.panel2.Controls.Add(this.lab_userName);
            this.panel2.Controls.Add(this.lab_pass);
            this.panel2.Controls.Add(this.but_retrieve);
            this.panel2.Location = new System.Drawing.Point(15, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 400);
            this.panel2.TabIndex = 0;
            // 
            // txt_privilege
            // 
            this.txt_privilege.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_privilege.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_privilege.FormattingEnabled = true;
            this.txt_privilege.Items.AddRange(new object[] {
            "student",
            "vendor",
            "administrator"});
            this.txt_privilege.Location = new System.Drawing.Point(124, 197);
            this.txt_privilege.Name = "txt_privilege";
            this.txt_privilege.Size = new System.Drawing.Size(207, 32);
            this.txt_privilege.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(356, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 548);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(133)))), ((int)(((byte)(120)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.privilegeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logInBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 454);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // privilegeDataGridViewTextBoxColumn
            // 
            this.privilegeDataGridViewTextBoxColumn.DataPropertyName = "Privilege";
            this.privilegeDataGridViewTextBoxColumn.HeaderText = "Privilege";
            this.privilegeDataGridViewTextBoxColumn.Name = "privilegeDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.but_Menu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 543);
            this.panel1.TabIndex = 35;
            // 
            // but_Menu
            // 
            this.but_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_Menu.BackgroundImage")));
            this.but_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.but_Menu.Location = new System.Drawing.Point(0, 484);
            this.but_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Menu.Name = "but_Menu";
            this.but_Menu.Size = new System.Drawing.Size(67, 58);
            this.but_Menu.TabIndex = 1;
            this.but_Menu.UseVisualStyleBackColor = true;
            this.but_Menu.Click += new System.EventHandler(this.but_Menu_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDatabaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_retrieve;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lab_privilege;
        private System.Windows.Forms.Label lab_pass;
        private System.Windows.Forms.Label lab_userName;
        private System.Windows.Forms.Label lab_lastName;
        private System.Windows.Forms.Label lab_firstName;
        private AppDatabaseDataSet appDatabaseDataSet;
        private System.Windows.Forms.BindingSource logInBindingSource;
        private AppDatabaseDataSetTableAdapters.LogInTableAdapter logInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_privilege;
    }
}