namespace Invoice_Master.UI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserRole = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.pnlHeader.Controls.Add(this.pictureBoxClose);
            this.pnlHeader.Controls.Add(this.lblTop);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1177, 39);
            this.pnlHeader.TabIndex = 8;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1139, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 27);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 5;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Beige;
            this.lblTop.Location = new System.Drawing.Point(508, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(107, 21);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "UTILISATEURS";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 105);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 17);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Prénom";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(134, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(241, 25);
            this.txtFirstName.TabIndex = 31;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(134, 134);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(241, 25);
            this.txtSurname.TabIndex = 32;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(13, 136);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 17);
            this.lblSurname.TabIndex = 12;
            this.lblSurname.Text = "Nom";
            this.lblSurname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(134, 389);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(241, 106);
            this.txtAddress.TabIndex = 39;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 391);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adresse";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 25);
            this.txtEmail.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 17);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(134, 260);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 25);
            this.txtUsername.TabIndex = 35;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 262);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 17);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Nom d\'utilisateur";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(134, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(241, 25);
            this.txtPassword.TabIndex = 36;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 17);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtUserRole
            // 
            this.txtUserRole.AutoSize = true;
            this.txtUserRole.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRole.Location = new System.Drawing.Point(13, 168);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(34, 17);
            this.txtUserRole.TabIndex = 22;
            this.txtUserRole.Text = "Rôle";
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(134, 358);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(241, 25);
            this.txtContact.TabIndex = 37;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(13, 362);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 17);
            this.lblContact.TabIndex = 26;
            this.lblContact.Text = "Contact";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.ItemHeight = 17;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Utilisateur",
            "Administrateur"});
            this.cmbUserRole.Location = new System.Drawing.Point(134, 165);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(241, 25);
            this.cmbUserRole.TabIndex = 33;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(134, 72);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(241, 25);
            this.txtUserID.TabIndex = 999999;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(13, 74);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(20, 17);
            this.lblUserID.TabIndex = 29;
            this.lblUserID.Text = "ID";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(430, 105);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(711, 556);
            this.dgvUsers.TabIndex = 31;
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(504, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(637, 25);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(427, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 17);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Recherche";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(134, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 35);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(134, 626);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 35);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 585);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 35);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1177, 698);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label txtUserRole;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}