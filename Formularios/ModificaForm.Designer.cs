namespace Prova.Formularios
{
    partial class ModificaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaForm));
            this.pdTextBox = new System.Windows.Forms.TextBox();
            this.vaTextBox = new System.Windows.Forms.TextBox();
            this.liTextBox = new System.Windows.Forms.TextBox();
            this.idaTextBox = new System.Windows.Forms.TextBox();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.linhaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mudarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdTextBox
            // 
            this.pdTextBox.Location = new System.Drawing.Point(107, 43);
            this.pdTextBox.Name = "pdTextBox";
            this.pdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pdTextBox.TabIndex = 0;
            // 
            // vaTextBox
            // 
            this.vaTextBox.Location = new System.Drawing.Point(107, 75);
            this.vaTextBox.Name = "vaTextBox";
            this.vaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vaTextBox.TabIndex = 1;
            // 
            // liTextBox
            // 
            this.liTextBox.Location = new System.Drawing.Point(107, 111);
            this.liTextBox.Name = "liTextBox";
            this.liTextBox.Size = new System.Drawing.Size(100, 20);
            this.liTextBox.TabIndex = 2;
            // 
            // idaTextBox
            // 
            this.idaTextBox.Location = new System.Drawing.Point(193, 12);
            this.idaTextBox.Name = "idaTextBox";
            this.idaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idaTextBox.TabIndex = 3;
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Location = new System.Drawing.Point(57, 46);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(44, 13);
            this.produtoLabel.TabIndex = 4;
            this.produtoLabel.Text = "Produto";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(59, 78);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(31, 13);
            this.valorLabel.TabIndex = 5;
            this.valorLabel.Text = "Valor";
            // 
            // linhaLabel
            // 
            this.linhaLabel.AutoSize = true;
            this.linhaLabel.Location = new System.Drawing.Point(59, 114);
            this.linhaLabel.Name = "linhaLabel";
            this.linhaLabel.Size = new System.Drawing.Size(33, 13);
            this.linhaLabel.TabIndex = 6;
            this.linhaLabel.Text = "Linha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o id do produto que ira alterar";
            // 
            // mudarButton
            // 
            this.mudarButton.Image = global::Prova.Properties.Resources.sav__2_;
            this.mudarButton.Location = new System.Drawing.Point(98, 146);
            this.mudarButton.Name = "mudarButton";
            this.mudarButton.Size = new System.Drawing.Size(109, 30);
            this.mudarButton.TabIndex = 8;
            this.mudarButton.Text = "Salvar Alteração";
            this.mudarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mudarButton.UseVisualStyleBackColor = true;
            this.mudarButton.Click += new System.EventHandler(this.mudarButton_Click);
            // 
            // ModificaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 181);
            this.Controls.Add(this.mudarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linhaLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.produtoLabel);
            this.Controls.Add(this.idaTextBox);
            this.Controls.Add(this.liTextBox);
            this.Controls.Add(this.vaTextBox);
            this.Controls.Add(this.pdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificaForm";
            this.Text = "ModificaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pdTextBox;
        private System.Windows.Forms.TextBox vaTextBox;
        private System.Windows.Forms.TextBox liTextBox;
        private System.Windows.Forms.TextBox idaTextBox;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label linhaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mudarButton;
    }
}