namespace Prova.Formularios
{
    partial class ProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoForm));
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.linhaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.linhaLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.Location = new System.Drawing.Point(70, 12);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.produtoTextBox.TabIndex = 0;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(70, 40);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 1;
            // 
            // linhaTextBox
            // 
            this.linhaTextBox.Location = new System.Drawing.Point(70, 66);
            this.linhaTextBox.Name = "linhaTextBox";
            this.linhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.linhaTextBox.TabIndex = 2;
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Location = new System.Drawing.Point(20, 12);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(44, 13);
            this.produtoLabel.TabIndex = 3;
            this.produtoLabel.Text = "Produto";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(20, 40);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(31, 13);
            this.valorLabel.TabIndex = 4;
            this.valorLabel.Text = "Valor";
            // 
            // linhaLabel
            // 
            this.linhaLabel.AutoSize = true;
            this.linhaLabel.Location = new System.Drawing.Point(20, 66);
            this.linhaLabel.Name = "linhaLabel";
            this.linhaLabel.Size = new System.Drawing.Size(33, 13);
            this.linhaLabel.TabIndex = 5;
            this.linhaLabel.Text = "Linha";
            // 
            // saveButton
            // 
            this.saveButton.Image = global::Prova.Properties.Resources.sav__2_;
            this.saveButton.Location = new System.Drawing.Point(46, 92);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(1);
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Salvar";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 121);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.linhaLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.produtoLabel);
            this.Controls.Add(this.linhaTextBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.produtoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.MaskedTextBox linhaTextBox;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label linhaLabel;
        private System.Windows.Forms.Button saveButton;
    }
}