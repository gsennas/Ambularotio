using Ambulatorio.Models;
using Ambulatorio.Models.Enun;
using System.Collections.Generic;

namespace Ambulatorio.Repository
{
    public class SeedingService
    {
        public void Seeding()
        {

            ICollection<Especialidade> especialidades = new List<Especialidade>();
            Especialidade a = new Especialidade(1, "Clinica Médica", Conselho.CRM);
            Especialidade b = new Especialidade(2, "Ortopedia", Conselho.CRM);
            Especialidade c = new Especialidade(3, "BucoMaxilo", Conselho.CRM);
            Especialidade d = new Especialidade(4, "Pediatra", Conselho.CRM);
            Especialidade e = new Especialidade(5, "Fisioterapia", Conselho.CRF);
            Especialidade f = new Especialidade(6, "Nutrição", Conselho.CRN);
            Especialidade g = new Especialidade(7, "Dentista", Conselho.CRO);
            Especialidade h = new Especialidade(8, "Enfermeiro", Conselho.COREN);
            Especialidade i = new Especialidade(9, "Auxiliar de Enfermagem", Conselho.COREN);
            especialidades.Add(a);
            especialidades.Add(b);
            especialidades.Add(c);
            especialidades.Add(d);
            especialidades.Add(e);
            especialidades.Add(f);
            especialidades.Add(g);
            especialidades.Add(h);
            especialidades.Add(i);

            
            Paciente pac1 = new Paciente(1, "Gláucio Senna", Sexo.Masculino, DateTime.Now, "Rua Jovem Viana", 158, "Casa",
                                        "Centro", "Rio das Ostras", "RJ", 28893452);
            Paciente pac2 = new Paciente(2, "Lucas Bispo", Sexo.Masculino, DateTime.Now, "Rua  Viana", 300, "apt 203",
                                        "Novo Rio das Ostras", "Rio das Ostras", "RJ", 28893452);
            
            Context.AdcionarPaciente(pac1);
            Context.AdcionarPaciente(pac2);
                       

            ICollection<Profissional> profissionals = new List<Profissional>();
            Profissional pro1 = new Profissional(1, "Joice Bispo", Sexo.Feminino, DateTime.Now, "Rua  Viana", 300, "apt 203",
                                        "Novo Rio das Ostras", "Rio das Ostras", "RJ", 28893452, TipoProfissional.Medico);
            Profissional pro2 = new Profissional(1, "Jeany XXXX", Sexo.Feminino, DateTime.Now, "Rua  Mauro Viana", 100,
                                        "casa", "Marileia", "Macaé", "RJ", 28893200, TipoProfissional.Enfemeiro);
            profissionals.Add(pro1);
            profissionals.Add(pro2);

            ICollection<Telefone> telefones = new List<Telefone>();
            Telefone t1 = new Telefone(1, 21, 983653100, TipoTelefone.Celular, 1, 0);
            Telefone t2 = new Telefone(1, 22, 555555555, TipoTelefone.Residencial, 1, 0);
            Telefone t3 = new Telefone(1, 21, 999999999, TipoTelefone.Celular, 2, 0);
            Telefone t4 = new Telefone(1, 21, 888888888, TipoTelefone.Celular, 0, 1);
            Telefone t5 = new Telefone(1, 21, 777777777, TipoTelefone.Comercial, 0, 1);
            Telefone t6 = new Telefone(1, 21, 666666666, TipoTelefone.Comercial, 0, 2);
            telefones.Add(t1);
            telefones.Add(t2);
            telefones.Add(t3);
            telefones.Add(t4);
            telefones.Add(t5);
            telefones.Add(t6);
            ICollection<RelacionamentoProfissionalEspecialidade> relacinamentos = new List<RelacionamentoProfissionalEspecialidade>();
            RelacionamentoProfissionalEspecialidade rel1 = new RelacionamentoProfissionalEspecialidade(1, 1, 4);
            RelacionamentoProfissionalEspecialidade rel2 = new RelacionamentoProfissionalEspecialidade(2, 1, 1);
            RelacionamentoProfissionalEspecialidade rel3 = new RelacionamentoProfissionalEspecialidade(3, 2, 9);
            relacinamentos.Add(rel1);
            relacinamentos.Add(rel2);
            relacinamentos.Add(rel3);
        }
    }
}