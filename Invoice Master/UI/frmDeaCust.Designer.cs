namespace Invoice_Master.UI
{
    partial class frmDeaCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvDeaCust = new System.Windows.Forms.DataGridView();
            this.txtDeaCustID = new System.Windows.Forms.TextBox();
            this.lblDeaCustID = new System.Windows.Forms.Label();
            this.cmbDeaCustRole = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtDeaCustRole = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 35);
            this.btnUpdate.TabIndex = 1000032;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(134, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 35);
            this.btnDelete.TabIndex = 1000033;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(134, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 35);
            this.btnAdd.TabIndex = 1000031;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(504, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(637, 25);
            this.txtSearch.TabIndex = 1000034;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(427, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 17);
            this.lblSearch.TabIndex = 1000013;
            this.lblSearch.Text = "Recherche";
            // 
            // dgvDeaCust
            // 
            this.dgvDeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeaCust.Location = new System.Drawing.Point(430, 105);
            this.dgvDeaCust.Name = "dgvDeaCust";
            this.dgvDeaCust.ReadOnly = true;
            this.dgvDeaCust.Size = new System.Drawing.Size(711, 556);
            this.dgvDeaCust.TabIndex = 1000070;
            this.dgvDeaCust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust_RowHeaderMouseClick);
            // 
            // txtDeaCustID
            // 
            this.txtDeaCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeaCustID.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeaCustID.Location = new System.Drawing.Point(134, 72);
            this.txtDeaCustID.Name = "txtDeaCustID";
            this.txtDeaCustID.ReadOnly = true;
            this.txtDeaCustID.Size = new System.Drawing.Size(241, 25);
            this.txtDeaCustID.TabIndex = 1000060;
            // 
            // lblDeaCustID
            // 
            this.lblDeaCustID.AutoSize = true;
            this.lblDeaCustID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustID.Location = new System.Drawing.Point(13, 74);
            this.lblDeaCustID.Name = "lblDeaCustID";
            this.lblDeaCustID.Size = new System.Drawing.Size(20, 17);
            this.lblDeaCustID.TabIndex = 1000009;
            this.lblDeaCustID.Text = "ID";
            // 
            // cmbDeaCustRole
            // 
            this.cmbDeaCustRole.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeaCustRole.FormattingEnabled = true;
            this.cmbDeaCustRole.ItemHeight = 17;
            this.cmbDeaCustRole.Items.AddRange(new object[] {
            "Fournisseur",
            "Client"});
            this.cmbDeaCustRole.Location = new System.Drawing.Point(133, 102);
            this.cmbDeaCustRole.Name = "cmbDeaCustRole";
            this.cmbDeaCustRole.Size = new System.Drawing.Size(241, 25);
            this.cmbDeaCustRole.TabIndex = 1000026;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(134, 227);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(241, 25);
            this.txtContact.TabIndex = 1000029;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(13, 231);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 17);
            this.lblContact.TabIndex = 1000008;
            this.lblContact.Text = "Contact";
            // 
            // txtDeaCustRole
            // 
            this.txtDeaCustRole.AutoSize = true;
            this.txtDeaCustRole.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeaCustRole.Location = new System.Drawing.Point(12, 105);
            this.txtDeaCustRole.Name = "txtDeaCustRole";
            this.txtDeaCustRole.Size = new System.Drawing.Size(34, 17);
            this.txtDeaCustRole.TabIndex = 1000007;
            this.txtDeaCustRole.Text = "Rôle";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 25);
            this.txtEmail.TabIndex = 1000028;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 17);
            this.lblEmail.TabIndex = 1000004;
            this.lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(134, 258);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(241, 106);
            this.txtAddress.TabIndex = 1000030;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 260);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 17);
            this.lblAddress.TabIndex = 1000003;
            this.lblAddress.Text = "Adresse";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(134, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 25);
            this.txtName.TabIndex = 1000027;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 1000002;
            this.lblName.Text = "Nom";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.pnlHeader.Controls.Add(this.pictureBoxClose);
            this.pnlHeader.Controls.Add(this.lblTop);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1178, 39);
            this.pnlHeader.TabIndex = 1000000;
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
            this.lblTop.Size = new System.Drawing.Size(204, 21);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "FOURNISSEURS ET CLIENTS";
            // 
            // frmDeaCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 699);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDeaCust);
            this.Controls.Add(this.txtDeaCustID);
            this.Controls.Add(this.lblDeaCustID);
            this.Controls.Add(this.cmbDeaCustRole);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtDeaCustRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeaCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeaCust";
            this.Load += new System.EventHandler(this.frmDeaCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvDeaCust;
        private System.Windows.Forms.TextBox txtDeaCustID;
        private System.Windows.Forms.Label lblDeaCustID;
        private System.Windows.Forms.ComboBox cmbDeaCustRole;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label txtDeaCustRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
    }
}