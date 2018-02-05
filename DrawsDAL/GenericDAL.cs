using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawsDAL
{
    public class GenericDAL<T> : Repository<T> where T : class
    {
        public DbContext myDbContext;

        public GenericDAL(DbContext context)
        {
            this.myDbContext = context;
        }
        public void Actualizar( T obj )
        {
            myDbContext.Set<T>().Attach( obj );
            myDbContext.Entry( obj ).State = EntityState.Modified;
        }

        public void Eliminar( T obj )
        {
            myDbContext.Set<T>().Remove( obj );
        }

        public void GuardarCambios()
        {
            myDbContext.SaveChanges();
        }

        public T Insertar( T obj )
        {
            myDbContext.Set<T>().Add( obj );

            return obj;
        }

        public  T ObtenerPorId( int id )
        {
            return myDbContext.Set<T>().Find( id );
        }

        public  T ObtenerPorId(params object[] id)
        {
            return myDbContext.Set<T>().Find( id );
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return myDbContext.Set<T>().ToList();
        }
    }
}
