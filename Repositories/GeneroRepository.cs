using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repository

{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// ou seja, vamos imolementar os métodos, toda a lógica do métodos.
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// variavél privada e somente leitura.
        /// </summary>
        private readonly Filmes_Context _context;



        /// <summary>
        /// Construtor do repositório
        /// Aqui toda vez que p construtor for chamado,
        /// os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto"></param>
        public GeneroRepository(Filmes_Context contexto) 
        {
            _context = contexto;
        }



        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero"></param>

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //adiciona um novo genero na tabela genero(BD)
                _context.Generos.Add(novoGenero);

                //Após o cadastro, salva as alterações
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> ListaGeneros = _context.Generos.ToList();

                return ListaGeneros;
            }
            catch (Exception)
            {
                throw;
            }
             
        }
    }
}
