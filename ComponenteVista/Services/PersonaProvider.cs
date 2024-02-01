
namespace VistasParciales.Services
{
    public class PersonaProvider : IPersonaProvider
    {
        public List<Persona> PersonaList
        {
            get;
            private set;
        }
        public PersonaProvider()
        {
            PersonaList = InicializarPersonas();
        }

        public List<Persona> InicializarPersonas()
        {
            return new List<Persona>() 
            { 
            new Persona("Christian","gffd","sdfsdf 56","545123"),
            new Persona("Jorge","ffff","csadf 415","456465"),
            new Persona("Manuel","asdf","gggg 5","5456456")
            };
        }
    }
}
