using System;
using System.Linq;
using System.Windows.Forms;
using TestePrático;

namespace TestePrático
{
    public partial class FormVisualizar : Form
    {
        private int turmaId;

        public FormVisualizar(int turmaId)
        {
            InitializeComponent();
            this.turmaId = turmaId;

            PreencherDadosTurma();
            this.FormClosing += FormVisualizar_FormClosing;
        }

        private void PreencherDadosTurma()
        {
            Login database = new Login();
            Turma turma = database.GetTurmaById(turmaId);

            if (turma != null)
            {
                lblTurma.Text = turma.Nome;
                lblProfessor.Text = turma.NomeProfessor;
            }
            else
            {
                MessageBox.Show("Turma não encontrada.");
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            // Verifica se a turma tem atividades
            if (login.TurmaTemAtividades(turmaId))
            {
                MessageBox.Show("Você não pode excluir uma turma com atividades cadastradas.");
                return;
            }

            // Confirmação de exclusão
            var confirmResult = MessageBox.Show("Você tem certeza que deseja excluir esta turma?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (login.ExcluirTurma(turmaId))
                {
                    MessageBox.Show("Turma excluída com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a turma.");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVisualizar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (formMain != null)
            {
                formMain.CarregarTurmas();
            }
        }
    }
}
