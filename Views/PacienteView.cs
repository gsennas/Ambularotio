using Ambulatorio.Models.Enun;
using Ambulatorio.Models;
using Ambulatorio.Repository;

namespace Ambulatorio.Views

{
    public class PacienteView
    {
        public void NovoPaciente()
        {
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            bool validaSexo = false;
            Sexo enun = new Sexo();
            int index = 2;
            while (!validaSexo)
            {
                System.Console.Write("Sexo (M:Mascuulino, F:Feminino, N:Não Informado) ");
                char sexo = char.Parse(Console.ReadLine());

                if (sexo.ToString().ToUpper() == "F" | sexo.ToString().ToUpper() == "M" | sexo.ToString().ToUpper() == "I")
                {
                    if (sexo.ToString().ToUpper() == "F")
                    {
                        enun = Sexo.Feminino;
                        validaSexo = true;
                    }
                    else if (sexo.ToString().ToUpper() == "M")
                    {
                        enun = Sexo.Masculino;
                        validaSexo = true;
                    }
                    else if (sexo.ToString().ToUpper() == "I")
                    {
                        enun = Sexo.NaoInformado;
                        validaSexo = true;
                    }
                }
                else { System.Console.WriteLine($"Informe (M:Mascuulino, F:Feminino, N:Não Informado) {sexo} Nao é uma opção válida! ");}
            }
            System.Console.Write("Data de Nascimento: (dd/mm/YYYY)");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Endereço: ");
            string endereco = (Console.ReadLine());
            System.Console.Write("Número: ");
            int numeroResidencia = int.Parse(Console.ReadLine());
            System.Console.Write("Complemento: ");
            string complemento = (Console.ReadLine());
            System.Console.Write("Bairro: ");
            string bairro = (Console.ReadLine());
            System.Console.Write("Cidade: ");
            string cidade = (Console.ReadLine());
            System.Console.Write("Estado: ");
            string estado = (Console.ReadLine());
            System.Console.Write("CEP: ");
            int cEP = int.Parse(Console.ReadLine());

            var paciente = new Paciente(index++,nome, enun, dtNascimento, endereco, numeroResidencia, complemento, 
                                    bairro, cidade, estado, cEP );
            Context.AdcionarPaciente(paciente);
        }
        public void PesquisarPacienteNome()
        {
            System.Console.Write("Entre com o nome do Paciente:");
            string nome = Console.ReadLine();
            Context.PesquisarNomePaciente(nome);
        }
        public static void PesquisarPacienteId()
        {
            System.Console.Write("Entre com o prontuário do Paciente:");
            int pront = int.Parse(Console.ReadLine());
            Context.PesquisarIdPaciente(pront);
        }
    }
}