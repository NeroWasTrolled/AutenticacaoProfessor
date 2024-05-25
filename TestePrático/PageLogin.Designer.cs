namespace TestePrático
{
	partial class PageLogin
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "BEM VINDO";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(95, 139);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(315, 29);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(95, 188);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(315, 29);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.White;
			this.btnEntrar.Location = new System.Drawing.Point(189, 250);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(127, 50);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// PageLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 343);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PageLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnEntrar;
	}
}

