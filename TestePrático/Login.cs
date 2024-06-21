using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using MySqlConnector;

namespace TestePrático
{
    public class Login
    {
        static string conn = @"server=sql10.freesqldatabase.com;port=3306;database=sql10714026;user=sql10714026;password=pf5lL1idAD";

        public List<Turma> GetTurmasByProfessor(int professorId)
        {
            List<Turma> turmas = new List<Turma>();

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT t.Id, t.Nome AS Turma, p.Nome FROM Turma t JOIN Professor p ON t.ProfessorId = p.Id WHERE t.ProfessorId = @ProfessorId", connection))
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
                            int id = reader.GetInt32("Id");
                            int idProfessor = professorId;
                            string nomeProfessor = reader.GetString("Nome");
                            string nomeTurma = reader.GetString("Turma");
                            turmas.Add(new Turma(id, idProfessor, nomeTurma, nomeProfessor));
                        }
                    }
                }
            }

            return turmas;
        }

        public Turma GetTurmaById(int turmaId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT t.Id, t.Nome AS Turma, t.ProfessorId, p.Nome AS NomeProfessor FROM Turma t JOIN Professor p ON t.ProfessorId = p.Id WHERE t.Id = @TurmaId", connection))
                {
                    command.Parameters.AddWithValue("@TurmaId", turmaId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            int professorId = reader.GetInt32("ProfessorId");
                            string nomeTurma = reader.GetString("Turma");
                            string nomeProfessor = reader.GetString("NomeProfessor");

                            return new Turma(id, professorId, nomeTurma, nomeProfessor);
                        }
                    }
                }
            }
            return null;
        }


        public bool ExcluirTurma(int turmaId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("DELETE FROM Turma WHERE id = @TurmaId", connection))
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
                using (var command = new MySqlCommand("SELECT COUNT(*) FROM Professor WHERE Email = @Email AND Senha = @Senha", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);  
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine($"Email: {email}, Senha: {senha}, Count: {count}"); 
                    return count > 0;
                }
            }
        }

        public string GetNomeById(int userId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT Nome FROM Professor WHERE Id = @UserId", connection))
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
                using (var command = new MySqlCommand("SELECT Id FROM Professor WHERE Email = @Email", connection))
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

        public bool CadastrarAtividade(int turmaId, string descricao)
        {
            using (var connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("INSERT INTO Atividade (Descricao, TurmaId) VALUES (@Descricao, @TurmaId)", connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@TurmaId", turmaId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastrar atividade: " + ex.Message);
                    return false;
                }
            }
        }

        public bool TurmaTemAtividades(int turmaId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT COUNT(*) FROM Atividade WHERE TurmaId = @TurmaId", connection))
                {
                    command.Parameters.AddWithValue("@TurmaId", turmaId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public bool ExcluirAtividade(int atividadeId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("DELETE FROM Atividade WHERE Id = @AtividadeId", connection))
                    {
                        command.Parameters.AddWithValue("@AtividadeId", atividadeId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao excluir atividade: " + ex.Message);
                    return false;
                }
            }
        }

        public List<Atividade> GetAtividadesByTurma(int turmaId)
        {
            List<Atividade> atividades = new List<Atividade>();

            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM Atividade WHERE TurmaId = @TurmaId", connection))
                {
                    command.Parameters.AddWithValue("@TurmaId", turmaId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string descricao = reader.GetString("Descricao");
                            atividades.Add(new Atividade(id, descricao, turmaId));
                        }
                    }
                }
            }

            return atividades;
        }

        public string GetNomeProfessor(int turmaId)
        {
            using (var connection = new MySqlConnection(conn))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT Nome FROM Professor WHERE Id = (SELECT ProfessorId FROM Turma WHERE Id = @TurmaId)", connection))
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
                using (var command = new MySqlCommand("SELECT Nome FROM Turma WHERE Id = @TurmaId", connection))
                {
                    command.Parameters.AddWithValue("@TurmaId", turmaId);
                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }
    }
}
