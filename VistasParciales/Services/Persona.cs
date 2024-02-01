using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace VistasParciales.Services
{
    public class Persona
    {
        public string Nombre { get;private set; }
        public string Apellido { get; private set; }
        public string Domicilio { get; private set; }
        public string Telefono { get; private set; }

        public Persona(string nombre, string apellido, string domicilio, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
        }

    }
}
