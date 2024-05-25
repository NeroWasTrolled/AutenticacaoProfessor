namespace TestePrático
{
	public class Turma
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string NomeProfessor { get; set; }
		public int Professor_id { get; set; }

		public Turma(int id, int idProfessor, string nome, string nomeProfessor)
		{
			Id = id;
			Professor_id = idProfessor;
			Nome = nome;
			NomeProfessor = nomeProfessor;
		}
	}
}
