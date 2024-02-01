namespace VistasEnlazadas.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Abierto { get; set; }
        public string Especialidad { get; set; }
        public int Review {  get; set; }
    }
}
