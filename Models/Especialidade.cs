using Ambulatorio.Models.Enun;

namespace Ambulatorio.Models
{
    public class Especialidade
    {
        public int Id_Especialidade { get; set; }
        public string Descricao { get; set; }
        public Conselho Conselho { get; set; }
       

        public Especialidade(int id_Especialidade, string descricao, Conselho conselho)
        {
            Id_Especialidade = id_Especialidade;
            Descricao = descricao;
            Conselho = conselho;
        }
    }
}