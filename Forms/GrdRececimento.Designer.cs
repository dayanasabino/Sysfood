namespace SysFood.Forms
{
    partial class GrdRecebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrdRecebimento));
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGVRecebimento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecebimento)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CmbStatus.Location = new System.Drawing.Point(12, 11);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(103, 21);
            this.CmbStatus.TabIndex = 14;
            this.CmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGVRecebimento
            // 
            this.DGVRecebimento.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVRecebimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecebimento.Location = new System.Drawing.Point(12, 48);
            this.DGVRecebimento.Name = "DGVRecebimento";
            this.DGVRecebimento.Size = new System.Drawing.Size(465, 270);
            this.DGVRecebimento.TabIndex = 12;
            this.DGVRecebimento.DoubleClick += new System.EventHandler(this.DGVRecebimento_DoubleClick);
            // 
            // GrdRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGVRecebimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrdRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimentos";
            this.Load += new System.EventHandler(this.GrdRecebimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecebimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGVRecebimento;
    }
}