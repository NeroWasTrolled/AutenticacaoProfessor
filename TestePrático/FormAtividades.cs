using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestePrático
{
    public partial class FormAtividades : Form
    {
        private int turmaId;
        private Login database;

        public FormAtividades(int turmaId)
        {
            InitializeComponent();
            this.turmaId = turmaId;
            database = new Login();
            PreencherDadosTurma();
            CarregarAtividades();
        }

        private void PreencherDadosTurma()
        {
            Turma turma = database.GetTurmaById(turmaId);

            if (turma != null)
            {
                lblTurma.Text = $"Turma: {turma.Nome}";
                lblProfessor.Text = $"Professor: {turma.NomeProfessor}";
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

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvAtividades.Columns.Add(btnExcluir);

            List<Atividade> atividades = database.GetAtividadesByTurma(turmaId);

            foreach (Atividade atividade in atividades)
            {
                dgvAtividades.Rows.Add(atividade.Id, atividade.Descricao);
            }
        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            FormCadastroAtividade formCadastroAtividade = new FormCadastroAtividade(turmaId);
            formCadastroAtividade.ShowDialog();
            CarregarAtividades();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAtividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAtividades.Columns["Excluir"].Index)
            {
                int atividadeId = Convert.ToInt32(dgvAtividades.Rows[e.RowIndex].Cells["Id"].Value);
                var confirmResult = MessageBox.Show("Você tem certeza que deseja excluir esta atividade?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (database.ExcluirAtividade(atividadeId))
                    {
                        MessageBox.Show("Atividade excluída com sucesso!");
                        CarregarAtividades();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir a atividade.");
                    }
                }
            }
        }
    }
}
