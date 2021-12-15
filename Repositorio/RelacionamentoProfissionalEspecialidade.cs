namespace Ambulatorio.Repositorio
{
    public class RelacionamentoProfissionalEspecialidade
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public int EspecialidadeId { get; set; }

        public RelacionamentoProfissionalEspecialidade(int id, int profissionalId, int especialidadeId)
        {
            Id = id;
            ProfissionalId = profissionalId;
            EspecialidadeId = especialidadeId;
        }
    }
}