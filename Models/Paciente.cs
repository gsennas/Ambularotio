using Ambulatorio.Models.Enun;

namespace Ambulatorio.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Endereco { get; set; }
        public int NumeroResidencia { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public ICollection<Telefone> Telefone { get; set; }

        public Paciente(int id, string name, Sexo sexo, DateTime dtNascimento, string endereco, 
        int numeroResidencia, string complemento, string bairro, string cidade, string estado, 
        int cep)
        {
            Id = id;
            Name = name;
            Sexo = sexo;
            DtNascimento = dtNascimento;
            Endereco = endereco;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
    }
}