namespace Prova.Formularios
{
    partial class AlterarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarForm));
            this.edicaoDataGridView = new System.Windows.Forms.DataGridView();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edicaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // edicaoDataGridView
            // 
            this.edicaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edicaoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.edicaoDataGridView.Name = "edicaoDataGridView";
            this.edicaoDataGridView.Size = new System.Drawing.Size(776, 389);
            this.edicaoDataGridView.TabIndex = 7;
            this.edicaoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.edicaoDataGridView_CellContentClick);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Image = global::Prova.Properties.Resources.icons8_adicionar_30;
            this.adicionarButton.Location = new System.Drawing.Point(283, 407);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(178, 37);
            this.adicionarButton.TabIndex = 8;
            this.adicionarButton.Text = "Adicionar um novo produto";
            this.adicionarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Image = global::Prova.Properties.Resources.icons8_alterar_30;
            this.alterarButton.Location = new System.Drawing.Point(202, 407);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 37);
            this.alterarButton.TabIndex = 6;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = global::Prova.Properties.Resources.icons8_excluir_30;
            this.excluirButton.Location = new System.Drawing.Point(107, 407);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(89, 37);
            this.excluirButton.TabIndex = 5;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excluirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::Prova.Properties.Resources.icons8_atualizar_30;
            this.buscarButton.Location = new System.Drawing.Point(12, 407);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(89, 37);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Atualizar";
            this.buscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // AlterarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.edicaoDataGridView);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.buscarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroForm";
            ((System.ComponentModel.ISupportInitialize)(this.edicaoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        public System.Windows.Forms.DataGridView edicaoDataGridView;
        private System.Windows.Forms.Button adicionarButton;
    }
}