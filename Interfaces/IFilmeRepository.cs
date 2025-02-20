using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme novoFilme);

        List<Genero> Listar();

        void Atualizar(Guid id, Filme filme);

        void Deletar(Guid id);

        Filme BuscarPorId(Guid id);
    }
}
