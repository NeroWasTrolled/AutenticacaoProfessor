using System;
using System.Windows.Forms;

namespace TestePrático
{
    public partial class FormCadastroAtividade : Form
    {
        private int turmaId;
        private Login database;

        public FormCadastroAtividade(int turmaId)
        {
            InitializeComponent();
            this.turmaId = turmaId;
            database = new Login();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;

            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira a descrição da atividade.");
                return;
            }

            if (database.CadastrarAtividade(turmaId, descricao))
            {
                MessageBox.Show("Atividade cadastrada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar atividade.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
