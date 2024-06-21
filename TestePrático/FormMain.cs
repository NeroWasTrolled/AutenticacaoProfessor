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
            dgvTurmas.Columns.Clear();
            dgvTurmas.Columns.Add("Id", "ID");
            dgvTurmas.Columns.Add("Nome", "Nome");

            List<Turma> turmas = database.GetTurmasByProfessor(Session.UserId);

            dgvTurmas.Rows.Clear();

            foreach (Turma turma in turmas)
            {
                dgvTurmas.Rows.Add(turma.Id, turma.Nome);
            }

            DataGridViewButtonColumn btnVisualizar = new DataGridViewButtonColumn();
            btnVisualizar.HeaderText = "Visualizar";
            btnVisualizar.Name = "Visualizar";
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseColumnTextForButtonValue = true;
            dgvTurmas.Columns.Add(btnVisualizar);
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTurmas.Columns["Visualizar"].Index)
            {
                int turmaId = Convert.ToInt32(dgvTurmas.Rows[e.RowIndex].Cells["Id"].Value);
                VisualizarTurma(turmaId);
            }
        }

        private void VisualizarTurma(int turmaId)
        {
            using (FormVisualizar formVisualizar = new FormVisualizar(turmaId))
            {
                formVisualizar.ShowDialog();
            }
        }
    }
}
