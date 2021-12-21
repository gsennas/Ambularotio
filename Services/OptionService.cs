using Ambulatorio.Repository;
using Ambulatorio.Views;
namespace Ambulatorio.Services
{
    public class OptionService
    {
        public void Option()
        {
            int option = 0;
            while (option != 4)
            {
                Console.Clear();
                MenuPrincipal();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MenuCadastroPaciente();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida: Escolha opções de 1 a 4");
                        break;
                }
            }




        }
        private static void MenuPrincipal()
        {
            System.Console.WriteLine("1 - Cadastro de Pacientes");
            System.Console.WriteLine("2 - Atendimento ");
            System.Console.WriteLine("3 - Manutenção de Tabelas");
            System.Console.WriteLine("4 - Sair do Sistma");
            System.Console.Write("Opção: ");
        }
        private static void MenuCadastroPaciente()
        {
            int option = 0;
            while (option != 5)
            {
                System.Console.WriteLine("1 - Novo Paciente");
                System.Console.WriteLine("2 - Cadastro de Telefone ");
                System.Console.WriteLine("3 - Alteração de Paciente");
                System.Console.WriteLine("4 - Pesquisa de Paciente");
                System.Console.WriteLine("5 - Voltar ao menu Anterior");
                System.Console.Write("Escolha sua Opção: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        var novoPaciente = new PacienteView();
                        novoPaciente.NovoPaciente();
                        break;
                    case 2:
                        Context context = new Context();
                        context.ListarPaciente();
                        break;
                    case 3:
                        break;
                    case 4:
                        MenuPesquisaPaciente();
                        break;
                    case 5:
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida: Escolha opções de 1 a 5");
                        break;
                }
            }

        }
        private static void MenuPesquisaPaciente()
        {
            int option = 0;
            while (option != 3)
            {
                System.Console.WriteLine("1 - Pesquisa por Nome");
                System.Console.WriteLine("2 - Pesquisa por Prontuário ");
                System.Console.WriteLine("3 - Voltar ao menu Anterior");
                System.Console.Write("Escolha sua Opção: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        var pacienteView = new PacienteView();
                        pacienteView.PesquisarPacienteNome();                       
                        break;
                    case 2:
                        PacienteView.PesquisarPacienteId();
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida: Escolha opções de 1 a 5");
                        break;
                }
            }

        }
    }
}