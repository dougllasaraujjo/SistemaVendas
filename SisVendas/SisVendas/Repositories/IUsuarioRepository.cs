using System.Collections;
using System.Collections.Generic;
using SisVendas.Models;

namespace SisVendas.Repositories
{
    public interface IUsuarioRepository
    {
        void SaveUsuario(Usuario usuario);
        IList<Usuario> GetUsuarios();
    }
}