namespace SysFood.Forms
{
    partial class GrdGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrdGrupo));
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGVGrupo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrupo)).BeginInit();
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
            this.CmbStatus.TabIndex = 11;
            this.CmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGVGrupo
            // 
            this.DGVGrupo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGrupo.Location = new System.Drawing.Point(12, 48);
            this.DGVGrupo.Name = "DGVGrupo";
            this.DGVGrupo.Size = new System.Drawing.Size(465, 270);
            this.DGVGrupo.TabIndex = 9;
            this.DGVGrupo.DoubleClick += new System.EventHandler(this.DGVGrupo_DoubleClick);
            // 
            // GrdGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGVGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrdGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Grupo";
            this.Load += new System.EventHandler(this.GrdGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGVGrupo;
    }
}