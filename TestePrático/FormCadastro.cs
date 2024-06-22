using System;
using System.Windows.Forms;

namespace TestePrático
{
    public partial class FormCadastro : Form
    {
        private Login login;

        public FormCadastro()
        {
            InitializeComponent();
            login = new Login();
            PreencherNomeProfessor();
        }

        private void PreencherNomeProfessor()
        {
            if (Session.IsLoggedIn())
            {
                lblNome.Text = Session.Nome;
            }
            else
            {
                MessageBox.Show("Usuário não está logado.");
                this.Close();
            }
        }

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			string nomeTurma = txtTurma.Text.Trim();
			int idProfessor = Session.UserId;

			if (string.IsNullOrWhiteSpace(nomeTurma))
			{
				MessageBox.Show("Por favor, insira o nome da turma.");
				return;
			}

			if (login.CadastrarTurma(idProfessor, nomeTurma))
			{
				MessageBox.Show("Turma cadastrada com sucesso!");
				txtTurma.Clear();
			}
			else
			{
				MessageBox.Show("Erro ao cadastrar turma.");
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
