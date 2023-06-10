namespace Prova.Formularios
{
    partial class FuncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcDataGridView = new System.Windows.Forms.DataGridView();
            this.listaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagina ainda em desenvolvimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para mais detalhes entre em contato:";
            // 
            // funcDataGridView
            // 
            this.funcDataGridView.AllowUserToAddRows = false;
            this.funcDataGridView.AllowUserToDeleteRows = false;
            this.funcDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcDataGridView.Location = new System.Drawing.Point(16, 156);
            this.funcDataGridView.Name = "funcDataGridView";
            this.funcDataGridView.ReadOnly = true;
            this.funcDataGridView.Size = new System.Drawing.Size(240, 150);
            this.funcDataGridView.TabIndex = 2;
            this.funcDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcDataGridView_CellContentClick);
            this.funcDataGridView.Validated += new System.EventHandler(this.dataGridView1_Validated);
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(12, 127);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(101, 23);
            this.listaButton.TabIndex = 3;
            this.listaButton.Text = "Lista de contatos";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // FuncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 318);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.funcDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuncForm";
            this.Text = "FuncForm";
            ((System.ComponentModel.ISupportInitialize)(this.funcDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView funcDataGridView;
        private System.Windows.Forms.Button listaButton;
    }
}