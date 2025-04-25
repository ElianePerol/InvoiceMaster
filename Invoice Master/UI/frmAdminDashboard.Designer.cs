namespace Invoice_Master
{
    partial class frmAdminDashboard
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursEtClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lblAppLName = new System.Windows.Forms.Label();
            this.lblSHead = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 568);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1476, 39);
            this.pnlFooter.TabIndex = 0;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFooter.Location = new System.Drawing.Point(858, 13);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(161, 17);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Développé par Eliane Perol";
            this.lblFooter.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem,
            this.catégorieToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.fournisseursEtClientsToolStripMenuItem,
            this.inventairesToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1476, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripTop";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.catégorieToolStripMenuItem.Text = "Catégories";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.catégorieToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // fournisseursEtClientsToolStripMenuItem
            // 
            this.fournisseursEtClientsToolStripMenuItem.Name = "fournisseursEtClientsToolStripMenuItem";
            this.fournisseursEtClientsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.fournisseursEtClientsToolStripMenuItem.Text = "Fournisseurs et Clients";
            this.fournisseursEtClientsToolStripMenuItem.Click += new System.EventHandler(this.fournisseursEtClientsToolStripMenuItem_Click);
            // 
            // inventairesToolStripMenuItem
            // 
            this.inventairesToolStripMenuItem.Name = "inventairesToolStripMenuItem";
            this.inventairesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inventairesToolStripMenuItem.Text = "Inventaire";
            this.inventairesToolStripMenuItem.Click += new System.EventHandler(this.inventairesToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Utilisateur :";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblLoggedInUser.Location = new System.Drawing.Point(92, 28);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedInUser.TabIndex = 3;
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblAppFName.Location = new System.Drawing.Point(810, 465);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(119, 36);
            this.lblAppFName.TabIndex = 4;
            this.lblAppFName.Text = "INVOICE";
            this.lblAppFName.Click += new System.EventHandler(this.lblAppFName_Click);
            // 
            // lblAppLName
            // 
            this.lblAppLName.AutoSize = true;
            this.lblAppLName.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblAppLName.Location = new System.Drawing.Point(935, 465);
            this.lblAppLName.Name = "lblAppLName";
            this.lblAppLName.Size = new System.Drawing.Size(124, 36);
            this.lblAppLName.TabIndex = 5;
            this.lblAppLName.Text = "MASTER";
            this.lblAppLName.Click += new System.EventHandler(this.lblAppLName_Click);
            // 
            // lblSHead
            // 
            this.lblSHead.AutoSize = true;
            this.lblSHead.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(57)))));
            this.lblSHead.Location = new System.Drawing.Point(823, 501);
            this.lblSHead.Name = "lblSHead";
            this.lblSHead.Size = new System.Drawing.Size(220, 26);
            this.lblSHead.TabIndex = 6;
            this.lblSHead.Text = "Facturation et inventaire";
            this.lblSHead.Click += new System.EventHandler(this.lblSHead_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1476, 607);
            this.Controls.Add(this.lblSHead);
            this.Controls.Add(this.lblAppLName);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord administrateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label lblAppLName;
        private System.Windows.Forms.Label lblSHead;
        private System.Windows.Forms.ToolStripMenuItem fournisseursEtClientsToolStripMenuItem;
    }
}

