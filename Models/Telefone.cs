using Ambulatorio.Models.Enun;

namespace Ambulatorio.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public int NTelefone { get; set; }
        public TipoTelefone Tipo { get; set; }
        public int? PacienteId { get; set; }
        public int? ProfissionalId { get; set; }

        public Telefone(int id, int dDD, int nTelefone, TipoTelefone tipo, int? pacienteId , int? profissionalId )
        {
            Id = id;
            DDD = dDD;
            NTelefone = nTelefone;
            Tipo = tipo;
            PacienteId = pacienteId;
            ProfissionalId = profissionalId;
        }
    }
}