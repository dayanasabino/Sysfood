﻿namespace SysFood.Forms
{
    partial class GrdEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrdEmpresa));
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGVEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CmbStatus.Location = new System.Drawing.Point(12, 14);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(103, 21);
            this.CmbStatus.TabIndex = 8;
            this.CmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGVEmpresa
            // 
            this.DGVEmpresa.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpresa.Location = new System.Drawing.Point(12, 51);
            this.DGVEmpresa.Name = "DGVEmpresa";
            this.DGVEmpresa.Size = new System.Drawing.Size(465, 270);
            this.DGVEmpresa.TabIndex = 6;
            this.DGVEmpresa.DoubleClick += new System.EventHandler(this.DGVEmpresa_DoubleClick);
            // 
            // GrdEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGVEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrdEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Empresa";
            this.Load += new System.EventHandler(this.GrdEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGVEmpresa;
    }
}