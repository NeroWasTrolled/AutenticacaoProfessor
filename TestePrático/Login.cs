using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TestePrático
{
	public class Login
	{
		private static string conn = @"server=sql.freedb.tech;port=3306;database=freedb_TestePratico;user=freedb_Atividade;password=P4xufURJ!tKH9w*";

		public List<Turma> GetTurmasByProfessor(int professorId)
		{
			List<Turma> turmas = new List<Turma>();

			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT t.id, t.turma, p.nome FROM turma t JOIN professor p ON t.professor_id = p.id WHERE t.professor_id = @ProfessorId", connection))
				{
					command.Parameters.AddWithValue("@ProfessorId", professorId);
					using (var reader = command.ExecuteReader())
					{
						if (!reader.HasRows)
						{
							return turmas; 
						}

						while (reader.Read())
						{
							int id = reader.GetInt32("id");
							int idProfessor = professorId;
							string nomeProfessor = reader.GetString("nome");
							string nomeTurma = reader.GetString("turma");
							turmas.Add(new Turma(id, idProfessor, nomeTurma, nomeProfessor));
						}
					}
				}
			}

			return turmas;
		}

		public bool ExcluirTurma(int turmaId)
		{
			using (var connection = new MySqlConnection(conn))
			{
				try
				{
					connection.Open();
					using (var command = new MySqlCommand("DELETE FROM turma WHERE id = @TurmaId", connection))
					{
						command.Parameters.AddWithValue("@TurmaId", turmaId);
						command.ExecuteNonQuery();
						return true;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erro ao excluir turma: " + ex.Message);
					return false;
				}
			}
		}


		public bool ValidateLogin(string email, string senha)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT COUNT(*) FROM professor WHERE email = @Email AND senha = @Senha", connection))
				{
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@Senha", senha);
					return Convert.ToInt32(command.ExecuteScalar()) > 0;
				}
			}
		}

		public string GetNomeById(int userId)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT nome FROM professor WHERE id = @UserId", connection))
				{
					command.Parameters.AddWithValue("@UserId", userId);
					var result = command.ExecuteScalar();
					return result != null ? result.ToString() : "";
				}
			}
		}

		public int GetUserIdByEmail(string email)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT id FROM professor WHERE email = @Email", connection))
				{
					command.Parameters.AddWithValue("@Email", email);
					var result = command.ExecuteScalar();
					return result != null ? Convert.ToInt32(result) : 0;
				}
			}
		}

		public bool CadastrarTurma(int idProfessor, string nomeTurma, string nomeProfessor)
		{
			using (var connection = new MySqlConnection(conn))
			{
				try
				{
					connection.Open();
					using (var command = new MySqlCommand("INSERT INTO turma (professor_id, turma, nome) VALUES (@IdProfessor, @NomeTurma, @NomeProfessor)", connection))
					{
						command.Parameters.AddWithValue("@IdProfessor", idProfessor);
						command.Parameters.AddWithValue("@NomeTurma", nomeTurma);
						command.Parameters.AddWithValue("@NomeProfessor", nomeProfessor);
						command.ExecuteNonQuery();
						return true;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erro ao cadastrar turma: " + ex.Message);
					return false;
				}
			}
		}

		public string GetNomeProfessor(int turmaId)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT nome FROM professor WHERE id = (SELECT professor_id FROM turma WHERE id = @TurmaId)", connection))
				{
					command.Parameters.AddWithValue("@TurmaId", turmaId);
					var result = command.ExecuteScalar();
					return result != null ? result.ToString() : "";
				}
			}
		}

		public string GetNomeTurma(int turmaId)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT turma FROM turma WHERE id = @TurmaId", connection))
				{
					command.Parameters.AddWithValue("@TurmaId", turmaId);
					var result = command.ExecuteScalar();
					return result != null ? result.ToString() : "";
				}
			}
		}

		public Turma GetTurmaById(int turmaId)
		{
			using (var connection = new MySqlConnection(conn))
			{
				connection.Open();
				using (var command = new MySqlCommand("SELECT * FROM turma WHERE id = @TurmaId", connection))
				{
					command.Parameters.AddWithValue("@TurmaId", turmaId);
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							int id = reader.GetInt32("id");
							int professorId = reader.GetInt32("professor_id");
							string nome = reader.GetString("nome");
							string turma = reader.GetString("turma");

							return new Turma(id, professorId, nome, turma);
						}
					}
				}
			}
			return null;
		}

	}
}
