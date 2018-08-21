using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase218.herencia;

namespace clase218.dao
{
    public class DAO_Persona : IDAO<Persona>
    {

        private List<Persona> lista;


        public DAO_Persona()
        {
            this.lista = new List<Persona>();
        }

        public void Create(Persona ob)
        {
            lista.Add(ob);
        }

        public void Delete(int id)
        {
            //lista.Remove(lista.Where(lista => lista.Id == id).First());

            lista.RemoveAll(p => p.Id == id);
        }

        public List<Persona> Read()
        {
            return lista;
        }

        public void Update(Persona ob)
        {
            throw new NotImplementedException();
        }
    }
}
