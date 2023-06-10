namespace Prova.Formularios
{
    partial class RegistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.nomerTextBox = new System.Windows.Forms.TextBox();
            this.senharTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.nomerLabel = new System.Windows.Forms.Label();
            this.senharLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomerTextBox
            // 
            this.nomerTextBox.Location = new System.Drawing.Point(12, 59);
            this.nomerTextBox.Name = "nomerTextBox";
            this.nomerTextBox.Size = new System.Drawing.Size(188, 20);
            this.nomerTextBox.TabIndex = 1;
            // 
            // senharTextBox
            // 
            this.senharTextBox.Location = new System.Drawing.Point(12, 122);
            this.senharTextBox.Name = "senharTextBox";
            this.senharTextBox.Size = new System.Drawing.Size(188, 20);
            this.senharTextBox.TabIndex = 2;
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Image = global::Prova.Properties.Resources.sav__2_;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(65, 190);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(62, 31);
            this.salvarButton.TabIndex = 0;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // nomerLabel
            // 
            this.nomerLabel.AutoSize = true;
            this.nomerLabel.Location = new System.Drawing.Point(13, 40);
            this.nomerLabel.Name = "nomerLabel";
            this.nomerLabel.Size = new System.Drawing.Size(42, 13);
            this.nomerLabel.TabIndex = 3;
            this.nomerLabel.Text = "NOME:";
            // 
            // senharLabel
            // 
            this.senharLabel.AutoSize = true;
            this.senharLabel.Location = new System.Drawing.Point(16, 106);
            this.senharLabel.Name = "senharLabel";
            this.senharLabel.Size = new System.Drawing.Size(47, 13);
            this.senharLabel.TabIndex = 4;
            this.senharLabel.Text = "SENHA:";
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 255);
            this.Controls.Add(this.senharLabel);
            this.Controls.Add(this.nomerLabel);
            this.Controls.Add(this.senharTextBox);
            this.Controls.Add(this.nomerTextBox);
            this.Controls.Add(this.salvarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TextBox nomerTextBox;
        private System.Windows.Forms.TextBox senharTextBox;
        private System.Windows.Forms.Label nomerLabel;
        private System.Windows.Forms.Label senharLabel;
    }
}