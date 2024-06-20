namespace TestePrático
{
    public class Turma
    {
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string NomeProfessor { get; set; }

        public Turma(int id, int professorId, string nome, string nomeProfessor)
        {
            Id = id;
            ProfessorId = professorId;
            Nome = nome;
            NomeProfessor = nomeProfessor;
        }
    }
}
