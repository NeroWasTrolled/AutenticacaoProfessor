using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestePrático
{
    public partial class FormMain : Form
    {
        private Login database;

        public FormMain()
        {
            InitializeComponent();
            database = new Login();
            LoadUserData();
            CarregarTurmas();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
            CarregarTurmas();
        }

        private void LoadUserData()
        {
            if (!Session.IsLoggedIn())
            {
                MessageBox.Show("Usuário não está logado.");
                this.Close();
            }
            else
            {
                lblNome.Text = Session.Nome;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.EndSession();
            MessageBox.Show("Você saiu da sessão.");
            this.Close();
            PageLogin loginForm = new PageLogin();
            loginForm.Show();
        }

        public void CarregarTurmas()
        {
            dgvTurmas.Rows.Clear();
            dgvTurmas.Columns.Clear();

            dgvTurmas.Columns.Add("Id", "Número");
            dgvTurmas.Columns.Add("Nome", "Nome");

            DataGridViewButtonColumn btnVisualizar = new DataGridViewButtonColumn
            {
                Name = "Visualizar",
                Text = "Visualizar",
                UseColumnTextForButtonValue = true
            };
            dgvTurmas.Columns.Add(btnVisualizar);

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn
            {
                Name = "Excluir",
                Text = "Excluir",
                UseColumnTextForButtonValue = true
            };
            dgvTurmas.Columns.Add(btnExcluir);

            List<Turma> turmas = database.GetTurmasByProfessor(Session.UserId);

            foreach (Turma turma in turmas)
            {
                dgvTurmas.Rows.Add(turma.Id, turma.Nome);
            }
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int turmaId = Convert.ToInt32(dgvTurmas.Rows[e.RowIndex].Cells["Id"].Value);

                if (dgvTurmas.Columns[e.ColumnIndex].Name == "Visualizar")
                {
                    VisualizarTurma(turmaId);
                }
                else if (dgvTurmas.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    ExcluirTurma(turmaId);
                }
            }
        }

        private void VisualizarTurma(int turmaId)
        {
            FormVisualizar formVisualizar = new FormVisualizar(turmaId);
            formVisualizar.Show();
        }

        private void ExcluirTurma(int turmaId)
        {
            var confirmResult = MessageBox.Show("Você tem certeza que deseja excluir esta turma?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (database.ExcluirTurma(turmaId))
                {
                    MessageBox.Show("Turma excluída com sucesso.");
                    CarregarTurmas();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir turma.");
                }
            }
        }
    }
}
