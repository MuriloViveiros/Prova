namespace Prova.Formularios
{
    partial class DeletarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarForm));
            this.deletarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteDutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletarTextBox
            // 
            this.deletarTextBox.Location = new System.Drawing.Point(16, 42);
            this.deletarTextBox.Name = "deletarTextBox";
            this.deletarTextBox.Size = new System.Drawing.Size(100, 20);
            this.deletarTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o codigo(ID) do produto que deseja remover:\r\n";
            // 
            // deleteDutton
            // 
            this.deleteDutton.Image = global::Prova.Properties.Resources.icons8_excluir_30;
            this.deleteDutton.Location = new System.Drawing.Point(152, 34);
            this.deleteDutton.Name = "deleteDutton";
            this.deleteDutton.Size = new System.Drawing.Size(96, 35);
            this.deleteDutton.TabIndex = 2;
            this.deleteDutton.Text = "Excluir";
            this.deleteDutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteDutton.UseVisualStyleBackColor = true;
            this.deleteDutton.Click += new System.EventHandler(this.deleteDutton_Click);
            // 
            // DeletarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 72);
            this.Controls.Add(this.deleteDutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletarTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarForm";
            this.Text = "DeletarForm";
            this.Load += new System.EventHandler(this.DeletarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteDutton;
    }
}