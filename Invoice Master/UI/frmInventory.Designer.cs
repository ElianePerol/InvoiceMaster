namespace Invoice_Master.UI
{
    partial class frmInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "ACHATS",
            "VENTES"});
            this.cmbCategory.Location = new System.Drawing.Point(156, 66);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(253, 25);
            this.cmbCategory.TabIndex = 1000059;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(28, 66);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 17);
            this.lblCategory.TabIndex = 1000058;
            this.lblCategory.Text = "Catégorie";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(26, 116);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(1120, 556);
            this.dgvProducts.TabIndex = 1000056;
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
            this.pnlHeader.TabIndex = 1000055;
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
            this.lblTop.Size = new System.Drawing.Size(94, 21);
            this.lblTop.TabIndex = 4;
            this.lblTop.Text = "INVENTAIRE";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightGreen;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(925, 66);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(221, 25);
            this.btnShowAll.TabIndex = 1000060;
            this.btnShowAll.Text = "Afficher tous les produits";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 704);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnShowAll;
    }
}
