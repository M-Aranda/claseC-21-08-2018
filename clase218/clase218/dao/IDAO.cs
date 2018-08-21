using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase218.dao
{

    // CRUD
    interface IDAO<T>
    {

        void Create(T ob);// insert
        List<T> Read(); // obtener todos los datos
        void Update(T ob); // actualizar
        void Delete(int id); // borrar


    }
}
