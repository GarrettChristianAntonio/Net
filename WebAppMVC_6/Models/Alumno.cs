namespace WebAppMVC_6.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }    
        public string Apellido { get; set; } 
        public string Email { get; set; }
        public Alumno(int paramId, string paramNombre, string paramApellido, string paramEmail)
        {
            Id = paramId;
            Nombre = paramNombre;
            Apellido = paramApellido;
            Email = paramEmail;
        }
    }
    
}
