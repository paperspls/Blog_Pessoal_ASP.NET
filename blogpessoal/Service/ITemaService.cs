namespace blogpessoal.Service
{
    public interface ITemaService
    {
        Task<IEnumerable<Tema>> GetAll();
        Task<Tema?> GetById(long id);
        Task<IEnumerable<Tema>> GetByDescricao(string descricao);
        Task<Tema?> Create(Tema Tema);
        Task<Tema?> Update(Tema Tema);
        Task Delete(Tema Tema);
    }
}
