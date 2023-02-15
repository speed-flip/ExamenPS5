namespace ExamenS5.models
{
    public class Libro : Recurso, ILibro
    {
        public int numeroPaginas { get; set; }
        public string tipo { get; set; }
        public bool online { get; set; } = false;

        public string pasarHoja()
        {
            return online ? "No puedes pasar hoja" : "Pasando a la siguiente hoja";
        }

        public override string Prestar()
        {
            return $"Se ha prestado el Libro {base.titulo} con una duracion de 8 dias";
        }

        public override string toString()
        {
            string disponibleOnline = online ? "esta disponible en linea" : "NO esta disponible en linea";
            return $"El Libro {base.titulo} fue escrito por {base.author} - sinopsis: {base.sinopsis} " +
                $"tiene {numeroPaginas} paginas, {disponibleOnline} y pertenece al tipo {tipo} \n";
        }

    }
}
