using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				txtEmail.Text = "E-mail";
				txtEmail.ForeColor = Color.Gray;
			}

			if (string.IsNullOrWhiteSpace(txtSenha.Text))
			{
				txtSenha.Text = "Senha";
				txtSenha.ForeColor = Color.Gray;
				txtSenha.UseSystemPasswordChar = false;
			}

			txtEmail.Enter += RemoveEmailPlaceholder;
			txtEmail.Leave += SetEmailPlaceholder;
			txtSenha.Enter += RemovePasswordPlaceholder;
			txtSenha.Leave += SetPasswordPlaceholder;
		}

		private void RemoveEmailPlaceholder(object sender, EventArgs e)
		{
			if (txtEmail.Text == "E-mail")
			{
				txtEmail.Text = "";
				txtEmail.ForeColor = Color.Black;
			}
		}

		private void SetEmailPlaceholder(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				txtEmail.Text = "E-mail";
				txtEmail.ForeColor = Color.Gray;
			}
		}

		private void RemovePasswordPlaceholder(object sender, EventArgs e)
		{
			if (txtSenha.Text == "Senha")
			{
				txtSenha.Text = "";
				txtSenha.ForeColor = Color.Black;
				txtSenha.UseSystemPasswordChar = true;
			}
		}

		private void SetPasswordPlaceholder(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtSenha.Text))
			{
				txtSenha.Text = "Senha";
				txtSenha.ForeColor = Color.Gray;
				txtSenha.UseSystemPasswordChar = false;
			}
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string senha = txtSenha.Text;

			// Remove placeholders para validação
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
