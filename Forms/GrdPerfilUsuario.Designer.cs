namespace SysFood.Forms
{
    partial class GrdPerfilUsuario
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
            this.DGVPerfilUsuario = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerfilUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPerfilUsuario
            // 
            this.DGVPerfilUsuario.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVPerfilUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerfilUsuario.Location = new System.Drawing.Point(12, 57);
            this.DGVPerfilUsuario.Name = "DGVPerfilUsuario";
            this.DGVPerfilUsuario.Size = new System.Drawing.Size(371, 270);
            this.DGVPerfilUsuario.TabIndex = 0;
            this.DGVPerfilUsuario.DoubleClick += new System.EventHandler(this.DGVPerfilUsuario_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 1;
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.CmbStatus.Location = new System.Drawing.Point(12, 20);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(103, 21);
            this.CmbStatus.TabIndex = 2;
            this.CmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // GrdPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(395, 339);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGVPerfilUsuario);
            this.Name = "GrdPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Perfil de Usuário";
            this.Load += new System.EventHandler(this.GrdPerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerfilUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPerfilUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbStatus;
    }
}