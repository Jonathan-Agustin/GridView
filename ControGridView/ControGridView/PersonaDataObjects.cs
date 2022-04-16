using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControGridView
{

    internal class PersonaDataObjects
    {
        private List<Persona> listaPersonas = new List<Persona>();

        public PersonaDataObjects()
        {
            Persona p1 = new Persona { Nombre = "Javier", Email = "javier@email.com"
            , Genero = "hombre", Telefono = "2228889993", ImagenGenero = "Hombre.png"};
            Persona p2 = new Persona { Nombre = "Rebecca", Email = "rebecca@email.com"
            , Genero = "mujer", Telefono = "2226655447", ImagenGenero = "Mujer.png"};
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
        }

        public List<Persona> listar()
        {
            return listaPersonas;
        }
    }
}
