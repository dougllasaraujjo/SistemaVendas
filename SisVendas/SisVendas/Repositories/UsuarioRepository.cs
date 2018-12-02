using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SisVendas.Models;

namespace SisVendas.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void SaveUsuario(Usuario usuario)
        {
            contexto.Set<Usuario>().Add(usuario);
        //    contexto.SaveChanges();
        }

        public IList<Usuario> GetUsuarios()
        {
            return contexto.Set<Usuario>().ToList();
        }
    }
}
