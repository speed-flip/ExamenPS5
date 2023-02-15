namespace ExamenS5.models
{
    public class Pelicula : Recurso, IPelicula
    {
        public int duracion { get; set; }
        public string genero { get; set; }

        public override string Prestar()
        {
            return $"Se ha prestado la pelicula {base.titulo} con una duracion de 2 dias";
        }

        public string Adelantar()
        {
            return $"Adelantando 10s...";
        }

        public string Atrasar()
        {
            return $"Atrasando 10s...";
        }

        public override string toString()
        {
            return $"La pelicula {base.titulo}, dirigida por {base.author} - sinopsis: {base.sinopsis} " +
                $"tiene {duracion} horas de duracion y pertenece al genero de {genero} " +
                $"fue lanzada el {base.fechaPublicacion}\n";
        }
    }
}
