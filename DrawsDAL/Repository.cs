using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawsDAL
{
    public interface Repository<TEntity> where TEntity : class
    {
        void Actualizar( TEntity obj );
        void Eliminar( TEntity obj );
        void GuardarCambios();
        TEntity Insertar( TEntity obj );
        TEntity ObtenerPorId( int id );
        TEntity ObtenerPorId(params object[]  id);
        IEnumerable<TEntity> ObtenerTodos();
    }
}
