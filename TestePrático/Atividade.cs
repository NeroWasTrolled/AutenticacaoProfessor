using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePrático
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TurmaId { get; set; }

        public Atividade(int id, string descricao, int turmaId)
        {
            Id = id;
            Descricao = descricao;
            TurmaId = turmaId;
        }
    }
}

