using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestePrático
{
    public partial class FormVisualizar : Form
    {
        private int turmaId;
        private Login database;

        public FormVisualizar(int turmaId)
        {
            InitializeComponent();
            this.turmaId = turmaId;
            database = new Login();

            PreencherDadosTurma();
            CarregarAtividades();
            this.FormClosing += FormVisualizar_FormClosing;
        }

        private void PreencherDadosTurma()
        {
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

        private void CarregarAtividades()
        {
            dgvAtividades.Rows.Clear();
            dgvAtividades.Columns.Clear();

            dgvAtividades.Columns.Add("Id", "Número");
            dgvAtividades.Columns.Add("Descricao", "Descrição");

            DataGridViewButtonColumn btnVisualizar = new DataGridViewButtonColumn();
            btnVisualizar.HeaderText = "Visualizar";
            btnVisualizar.Name = "Visualizar";
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseColumnTextForButtonValue = true;
            dgvAtividades.Columns.Add(btnVisualizar);

            List<Atividade> atividades = database.GetAtividadesByTurma(turmaId);

            foreach (Atividade atividade in atividades)
            {
                dgvAtividades.Rows.Add(atividade.Id, atividade.Descricao);
            }
        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            using (FormCadastroAtividade formCadastroAtividade = new FormCadastroAtividade(turmaId))
            {
                formCadastroAtividade.ShowDialog();
                CarregarAtividades();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.TurmaTemAtividades(turmaId))
            {
                MessageBox.Show("Você não pode excluir uma turma com atividades cadastradas.");
                return;
            }

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

        private void dgvAtividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAtividades.Columns["Visualizar"].Index)
            {
                int atividadeId = Convert.ToInt32(dgvAtividades.Rows[e.RowIndex].Cells["Id"].Value);
                using (FormAtividades formAtividades = new FormAtividades(turmaId))
                {
                    formAtividades.ShowDialog();
                }
            }
        }
    }
}
