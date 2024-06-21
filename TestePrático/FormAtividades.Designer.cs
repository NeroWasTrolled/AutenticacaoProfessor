namespace TestePrático
{
    partial class FormAtividades
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(12, 9);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 0;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 32);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Turma:";
            // 
            // dgvAtividades
            // 
            this.dgvAtividades.AllowUserToAddRows = false;
            this.dgvAtividades.AllowUserToDeleteRows = false;
            this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividades.Location = new System.Drawing.Point(12, 58);
            this.dgvAtividades.Name = "dgvAtividades";
            this.dgvAtividades.ReadOnly = true;
            this.dgvAtividades.Size = new System.Drawing.Size(360, 150);
            this.dgvAtividades.TabIndex = 2;
            this.dgvAtividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtividades_CellContentClick);
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(297, 214);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAtividade.TabIndex = 3;
            this.btnCadastrarAtividade.Text = "Cadastrar Atividade";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            this.btnCadastrarAtividade.Click += new System.EventHandler(this.btnCadastrarAtividade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(297, 243);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormAtividades
            // 
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Controls.Add(this.dgvAtividades);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblProfessor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtividades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIVIDADES DA TURMA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.Button btnSair;
    }
}
