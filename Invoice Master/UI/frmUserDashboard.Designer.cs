﻿namespace Invoice_Master
{
    partial class frmUserDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.achatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursEtClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSHead = new System.Windows.Forms.Label();
            this.lblAppLName = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.linkLblSupport = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achatsToolStripMenuItem,
            this.ventesToolStripMenuItem,
            this.inventairesToolStripMenuItem,
            this.fournisseursEtClientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1476, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStripTop";
            // 
            // achatsToolStripMenuItem
            // 
            this.achatsToolStripMenuItem.Name = "achatsToolStripMenuItem";
            this.achatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.achatsToolStripMenuItem.Text = "Achats";
            this.achatsToolStripMenuItem.Click += new System.EventHandler(this.achatsToolStripMenuItem_Click);
            // 
            // ventesToolStripMenuItem
            // 
            this.ventesToolStripMenuItem.Name = "ventesToolStripMenuItem";
            this.ventesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventesToolStripMenuItem.Text = "Ventes";
            this.ventesToolStripMenuItem.Click += new System.EventHandler(this.ventesToolStripMenuItem_Click);
            // 
            // inventairesToolStripMenuItem
            // 
            this.inventairesToolStripMenuItem.Name = "inventairesToolStripMenuItem";
            this.inventairesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inventairesToolStripMenuItem.Text = "Inventaire";
            this.inventairesToolStripMenuItem.Click += new System.EventHandler(this.inventairesToolStripMenuItem_Click);
            // 
            // fournisseursEtClientsToolStripMenuItem
            // 
            this.fournisseursEtClientsToolStripMenuItem.Name = "fournisseursEtClientsToolStripMenuItem";
            this.fournisseursEtClientsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.fournisseursEtClientsToolStripMenuItem.Text = "Fournisseurs et Clients";
            this.fournisseursEtClientsToolStripMenuItem.Click += new System.EventHandler(this.fournisseursEtClientsToolStripMenuItem_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblLoggedInUser.Location = new System.Drawing.Point(91, 24);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedInUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Utilisateur :";
            // 
            // lblSHead
            // 
            this.lblSHead.AutoSize = true;
            this.lblSHead.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(57)))));
            this.lblSHead.Location = new System.Drawing.Point(823, 501);
            this.lblSHead.Name = "lblSHead";
            this.lblSHead.Size = new System.Drawing.Size(220, 26);
            this.lblSHead.TabIndex = 10;
            this.lblSHead.Text = "Facturation et inventaire";
            // 
            // lblAppLName
            // 
            this.lblAppLName.AutoSize = true;
            this.lblAppLName.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblAppLName.Location = new System.Drawing.Point(935, 465);
            this.lblAppLName.Name = "lblAppLName";
            this.lblAppLName.Size = new System.Drawing.Size(124, 36);
            this.lblAppLName.TabIndex = 9;
            this.lblAppLName.Text = "MASTER";
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.lblAppFName.Location = new System.Drawing.Point(810, 465);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(119, 36);
            this.lblAppFName.TabIndex = 8;
            this.lblAppFName.Text = "INVOICE";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.pnlFooter.Controls.Add(this.linkLblSupport);
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 568);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1476, 39);
            this.pnlFooter.TabIndex = 7;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFooter.Location = new System.Drawing.Point(775, 13);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(207, 17);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Projet pédagogique | Eliane Perol | ";
            // 
            // linkLblSupport
            // 
            this.linkLblSupport.AutoSize = true;
            this.linkLblSupport.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblSupport.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLblSupport.Location = new System.Drawing.Point(977, 13);
            this.linkLblSupport.Name = "linkLblSupport";
            this.linkLblSupport.Size = new System.Drawing.Size(130, 17);
            this.linkLblSupport.TabIndex = 1;
            this.linkLblSupport.TabStop = true;
            this.linkLblSupport.Text = "Contacter le support";
            this.linkLblSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSupport_LinkClicked);
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1476, 607);
            this.Controls.Add(this.lblSHead);
            this.Controls.Add(this.lblAppLName);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord utilisateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmUserDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSHead;
        private System.Windows.Forms.Label lblAppLName;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.ToolStripMenuItem fournisseursEtClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventairesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLblSupport;
    }
}