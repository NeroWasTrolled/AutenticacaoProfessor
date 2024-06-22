using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestePrático
{
	public partial class PageLogin : Form
	{
		private Login login;

		public PageLogin()
		{
			InitializeComponent();
			login = new Login();
			SetPlaceholders();
		}

		private void SetPlaceholders()
		{
			SetPlaceholder(txtEmail, "E-mail", false);
			SetPlaceholder(txtSenha, "Senha", true);

			txtEmail.Enter += (s, e) => RemovePlaceholder(txtEmail, "E-mail", false);
			txtEmail.Leave += (s, e) => SetPlaceholder(txtEmail, "E-mail", false);
			txtSenha.Enter += (s, e) => RemovePlaceholder(txtSenha, "Senha", true);
			txtSenha.Leave += (s, e) => SetPlaceholder(txtSenha, "Senha", true);
		}

		private void SetPlaceholder(TextBox textBox, string placeholder, bool isPassword)
		{
			if (string.IsNullOrWhiteSpace(textBox.Text))
			{
				textBox.Text = placeholder;
				textBox.ForeColor = Color.Gray;
				textBox.UseSystemPasswordChar = isPassword;
			}
		}

		private void RemovePlaceholder(TextBox textBox, string placeholder, bool isPassword)
		{
			if (textBox.Text == placeholder)
			{
				textBox.Text = "";
				textBox.ForeColor = Color.Black;
				textBox.UseSystemPasswordChar = isPassword;
			}
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text.Trim();
			string senha = txtSenha.Text.Trim();

			if (email == "E-mail") email = "";
			if (senha == "Senha") senha = "";

			if (!IsValidEmail(email))
			{
				MessageBox.Show("Por favor, insira um email válido.");
				return;
			}

			if (!IsValidPassword(senha))
			{
				MessageBox.Show("A senha deve ter entre 8 e 12 caracteres, e deve conter letras e números.");
				return;
			}

			if (login.ValidateLogin(email, senha))
			{
				int userId = login.GetUserIdByEmail(email);
				string nome = login.GetNomeById(userId);
				Session.StartSession(userId, email, nome);

				MessageBox.Show("Login bem-sucedido!");
				this.Hide();
				FormMain formMain = new FormMain();
				formMain.Show();
			}
			else
			{
				MessageBox.Show("Email ou senha incorretos.");
			}
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private bool IsValidPassword(string password)
		{
			if (password.Length < 8 || password.Length > 12)
				return false;

			bool hasLetter = false;
			bool hasDigit = false;

			foreach (char c in password)
			{
				if (char.IsLetter(c))
					hasLetter = true;
				else if (char.IsDigit(c))
					hasDigit = true;

				if (hasLetter && hasDigit)
					return true;
			}

			return false;
		}
	}
}
