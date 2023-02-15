namespace ExamenS5.models
{
    public class Recurso
    {
        public string titulo { get; set; }
        public string author { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public string sinopsis { get; set; }

        public virtual string Prestar()
        {
            return $"Se ha prestado el recurso {titulo} con una duracion de [tiempo]";
        }

        public virtual string toString()
        {
            return $"Nombre: {titulo} con autor: {author} fue publicado {fechaPublicacion}";
        }
    }
}
