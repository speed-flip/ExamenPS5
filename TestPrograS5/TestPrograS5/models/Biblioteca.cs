namespace ExamenS5.models
{
    public class Biblioteca
    {
        public string nombre { get; set; }
        public List<Pelicula> peliculas { get; set; } = new List<Pelicula>();
        public List<Libro> libros { get; set; } = new List<Libro>();
        public List<AudioLibros> audioLibros { get; set; } = new List<AudioLibros>();
        public List<JuegosMesa> juegosMesa { get; set; } = new List<JuegosMesa>();

        public string getPeliculas()
        {
            string pelicula = "";

            foreach(Pelicula p in peliculas)
            {
                pelicula += $"-{p.titulo}\n";
            }

            return pelicula;
        }

        public string getLibros()
        {
            string libro = "";

            foreach (Libro lb in libros)
            {
                libro += $"-{lb.titulo}\n";
            }

            return libro;
        }

        public string getAudioLibros()
        {
            string audiolibro = "";

            foreach(AudioLibros ab in audioLibros)
            {
                audiolibro += $"-{ab.titulo}\n";
            }

            return audiolibro;
        }

        public string getJuegosMesa()
        {
            string juegoMesa = "";

            foreach (JuegosMesa jm in juegosMesa)
            {
                juegoMesa += $"-{jm.titulo}\n";
            }

            return juegoMesa;
        }

        public string bienvenida()
        {
            string listadoPeliculas = getPeliculas();
            string listadoLibros = getLibros();
            string listadoAB = getAudioLibros();
            string listadojm = getJuegosMesa();
            return $"La biblioteca {nombre} te da la bienvenida y te ofrece estas peliculas para poder disfrutar " +
                $"\n{listadoPeliculas}Tambien puedes disfrutar de nuestra hermosa coleccion de libros \n{listadoLibros}" +
                $"Y si te apasiona los libros pero no te gusta leer puedes disfutar de nuestra seccion de audiolibros \n{listadoAB}" +
                $"Si lo que quieres es diversion con tus amigos contamos con un listado de juegos de mesa \n{listadojm}";
        }

    }   
}
