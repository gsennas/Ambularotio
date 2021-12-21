using Ambulatorio.Models;
using Ambulatorio.Models.Enun;
using System.Collections.Generic;
using System.Linq;

namespace Ambulatorio.Repository
{
     class Context
    {
        private static ICollection<Paciente> pacientes = new List<Paciente>();
        
        public Context()
        {
        }

        public static void AdcionarPaciente(Paciente paciente) => pacientes.Add(paciente);
        
        public void ListarPaciente()
        {
            foreach (Paciente item in pacientes)
            {
                System.Console.WriteLine(item);
            }      
        }
         public static void PesquisarNomePaciente(string nome)
        {
           var pesquisaNome = pacientes.Where(p => p.Name.Contains(nome));
           Retorna(pesquisaNome);
        }
          public static void PesquisarIdPaciente(int id)
        {
            var pesquisaId = pacientes.Where(p => p.Id == id);
            Retorna(pesquisaId);
        }
        public static void Retorna<T> (IEnumerable<T> lista)
        {
            foreach (T item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}