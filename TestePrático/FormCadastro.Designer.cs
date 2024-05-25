namespace TestePrático
{
	partial class FormCadastro
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DodgerBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(553, 57);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(394, 7);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(141, 45);
			this.btnSair.TabIndex = 3;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.ForeColor = System.Drawing.Color.White;
			this.lblNome.Location = new System.Drawing.Point(27, 19);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(0, 20);
			this.lblNome.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "NOME DA TURMA";
			// 
			// txtTurma
			// 
			this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTurma.Location = new System.Drawing.Point(31, 185);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(407, 29);
			this.txtTurma.TabIndex = 6;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(290, 99);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(229, 41);
			this.btnCadastrar.TabIndex = 7;
			this.btnCadastrar.Text = "Cadastrar Turma";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 270);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtTurma);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCadastro";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE TURMA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.Button btnCadastrar;
	}
}