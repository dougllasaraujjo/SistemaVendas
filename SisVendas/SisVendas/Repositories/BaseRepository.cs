using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisVendas.Models;

namespace SisVendas.Repositories
{
    public class BaseRepository<T> where T : BaseModel 
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            DbSet = contexto.Set<T>();


        }
    }
}
