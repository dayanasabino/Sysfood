namespace SysFood.Forms
{
    partial class FrmTelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaVenda));
            this.CmbMercadoria = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TxtTotalParcial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtValorUnitario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnBuscaProduto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbMercadoria
            // 
            this.CmbMercadoria.FormattingEnabled = true;
            this.CmbMercadoria.Location = new System.Drawing.Point(73, 37);
            this.CmbMercadoria.Name = "CmbMercadoria";
            this.CmbMercadoria.Size = new System.Drawing.Size(280, 21);
            this.CmbMercadoria.TabIndex = 122;
            this.CmbMercadoria.SelectedIndexChanged += new System.EventHandler(this.CmbMercadoria_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(297, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 131;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(193, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 130;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtTotalParcial
            // 
            this.TxtTotalParcial.Enabled = false;
            this.TxtTotalParcial.Location = new System.Drawing.Point(295, 110);
            this.TxtTotalParcial.Name = "TxtTotalParcial";
            this.TxtTotalParcial.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalParcial.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "Valor Total:";
            // 
            // TxtValorUnitario
            // 
            this.TxtValorUnitario.Location = new System.Drawing.Point(294, 74);
            this.TxtValorUnitario.Name = "TxtValorUnitario";
            this.TxtValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.TxtValorUnitario.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 126;
            this.label12.Text = "Valor Unitário:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(93, 74);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 125;
            this.TxtQuantidade.Text = "1";
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "Quantidade:";
            // 
            // BtnBuscaProduto
            // 
            this.BtnBuscaProduto.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscaProduto.Location = new System.Drawing.Point(359, 35);
            this.BtnBuscaProduto.Name = "BtnBuscaProduto";
            this.BtnBuscaProduto.Size = new System.Drawing.Size(36, 23);
            this.BtnBuscaProduto.TabIndex = 123;
            this.BtnBuscaProduto.Text = "...";
            this.BtnBuscaProduto.UseVisualStyleBackColor = false;
            this.BtnBuscaProduto.Click += new System.EventHandler(this.BtnBuscaProduto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "Produto:";
            // 
            // FrmTelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(416, 237);
            this.Controls.Add(this.CmbMercadoria);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.TxtTotalParcial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtValorUnitario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnBuscaProduto);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            this.Load += new System.EventHandler(this.FrmTelaVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMercadoria;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TxtTotalParcial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtValorUnitario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnBuscaProduto;
        private System.Windows.Forms.Label label10;
    }
}