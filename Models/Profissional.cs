using Ambulatorio.Models.Enun;
namespace Ambulatorio.Models
{
    public class Profissional : Paciente
    {

      
        public TipoProfissional TipoProfissional { get; set; }
        public ICollection<Especialidade> Especialidade { get; set; }
        public Profissional(int id, string name, Sexo sexo, DateTime dtNascimento, string endereco,
        int numeroResidencia, string complemento, string bairro, string cidade, string estado, int cep,
         TipoProfissional tipoProfissional)
         : base(id, name, sexo, dtNascimento, endereco, numeroResidencia, complemento,
         bairro, cidade, estado, cep)
        {
            TipoProfissional = tipoProfissional;
        }



    }
}
