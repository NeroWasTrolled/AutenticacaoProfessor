namespace TestePrático
{
	partial class FormVisualizar
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
			this.lblTurma = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblProfessor = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTurma
			// 
			this.lblTurma.AutoSize = true;
			this.lblTurma.BackColor = System.Drawing.Color.Transparent;
			this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurma.ForeColor = System.Drawing.Color.Black;
			this.lblTurma.Location = new System.Drawing.Point(23, 92);
			this.lblTurma.Name = "lblTurma";
			this.lblTurma.Size = new System.Drawing.Size(0, 24);
			this.lblTurma.TabIndex = 0;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.ForeColor = System.Drawing.Color.White;
			this.lblNome.Location = new System.Drawing.Point(219, 17);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(0, 20);
			this.lblNome.TabIndex = 7;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(427, 5);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(140, 45);
			this.btnSair.TabIndex = 6;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DodgerBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(-42, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(751, 57);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lblProfessor
			// 
			this.lblProfessor.AutoSize = true;
			this.lblProfessor.BackColor = System.Drawing.Color.Transparent;
			this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfessor.ForeColor = System.Drawing.Color.Black;
			this.lblProfessor.Location = new System.Drawing.Point(23, 167);
			this.lblProfessor.Name = "lblProfessor";
			this.lblProfessor.Size = new System.Drawing.Size(0, 24);
			this.lblProfessor.TabIndex = 8;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Location = new System.Drawing.Point(427, 234);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(140, 45);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// FormVisualizar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 304);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.lblProfessor);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblTurma);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormVisualizar";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VISUALIZAR TURMA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTurma;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblProfessor;
		private System.Windows.Forms.Button btnExcluir;
	}
}