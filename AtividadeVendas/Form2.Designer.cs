﻿namespace AtividadeVendas
{
    partial class Frm2
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
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms1
            // 
            this.ms1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.sairToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(1067, 28);
            this.ms1.TabIndex = 0;
            this.ms1.Text = "Menu";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.nadadorToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fatoralToolStripMenuItem});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(60, 24);
            this.MenuItem1.Text = "Menu";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // nadadorToolStripMenuItem
            // 
            this.nadadorToolStripMenuItem.Name = "nadadorToolStripMenuItem";
            this.nadadorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nadadorToolStripMenuItem.Text = "Nadador";
            this.nadadorToolStripMenuItem.Click += new System.EventHandler(this.nadadorToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // fatoralToolStripMenuItem
            // 
            this.fatoralToolStripMenuItem.Name = "fatoralToolStripMenuItem";
            this.fatoralToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fatoralToolStripMenuItem.Text = "Fatoral !";
            this.fatoralToolStripMenuItem.Click += new System.EventHandler(this.fatoralToolStripMenuItem_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ms1);
            this.MainMenuStrip = this.ms1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nadadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatoralToolStripMenuItem;
    }
}