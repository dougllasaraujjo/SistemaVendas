using SisVendas.Models;
using SisVendas.Repositories;

namespace SisVendas
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IUsuarioRepository _usuarioRepository;

        public DataService(ApplicationContext contexto, IUsuarioRepository usuarioRepository)
        {
            this.contexto = contexto;
            _usuarioRepository = usuarioRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
            _usuarioRepository.SaveUsuario(new Usuario());
        }
    }
}
