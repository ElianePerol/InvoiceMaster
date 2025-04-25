namespace Invoice_Master.UI
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(135, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 35);
            this.btnUpdate.TabIndex = 1000035;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(135, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 35);
            this.btnDelete.TabIndex = 1000036;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(135, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 35);
            this.btnAdd.TabIndex = 1000034;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(505, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(637, 25);
            this.txtSearch.TabIndex = 1000037;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(428, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 17);
            this.lblSearch.TabIndex = 1000030;
            this.lblSearch.Text = "Recherche";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(431, 107);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(711, 556);
            this.dgvProducts.TabIndex = 1000027;
            this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(135, 74);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(241, 25);
            this.txtProductID.TabIndex = 1000028;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(14, 76);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(20, 17);
            this.lblProductID.TabIndex = 1000026;
            this.lblProductID.Text = "ID";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(135, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 106);
            this.txtDescription.TabIndex = 1000031;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 169);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 17);
            this.lblDescription.TabIndex = 1000025;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(135, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 25);
            this.txtName.TabIndex = 1000029;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 1000024;
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
            this.pnlHeader.Size = new System.Drawing.Size(1172, 39);
            this.pnlHeader.TabIndex = 1000023;
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
            this.lblTop.Size = new System.Drawing.Size(83, 21);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "PRODUITS";
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(135, 281);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(241, 25);
            this.txtRate.TabIndex = 1000032;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(14, 138);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 17);
            this.lblCategory.TabIndex = 1000036;
            this.lblCategory.Text = "Catégorie";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(14, 281);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(29, 17);
            this.lblRate.TabIndex = 1000038;
            this.lblRate.Text = "Prix";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 17;
            this.cmbCategory.Location = new System.Drawing.Point(135, 136);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(241, 25);
            this.cmbCategory.TabIndex = 1000030;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 706);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}