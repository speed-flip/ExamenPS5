using ExamenS5.models;

Biblioteca bienvenida = new Biblioteca()
{
    nombre = "PeLibros"
};

Pelicula peli1 = new Pelicula()
{
    titulo = "Pelicula 1",
    duracion = 2,
    author = "Director reconocido",
    sinopsis = "Una increible sinopsis",
    genero = "Accion",
    fechaPublicacion = new DateTime(2000, 05, 12),
};

Pelicula peli2 = new Pelicula()
{
    titulo = "Pelicula 2",
    duracion = 3,
    sinopsis = "Una increible sinopsis",
    author = "Director reconocido",
};

bienvenida.peliculas.Add(peli1);
bienvenida.peliculas.Add(peli2);

Libro l1 = new Libro()
{
    titulo = "Libro 1",
    numeroPaginas = 324,
    author = "Autor reconocido",
    tipo = "Novela",
    sinopsis = "Una increible sinopsis",
    online = true,
    fechaPublicacion = new DateTime(2000, 05, 12),
};

Libro l2 = new Libro()
{
    titulo = "Libro 2",
    numeroPaginas = 254,
    author = "Autor reconocido",
    sinopsis = "Una increible sinopsis",
    tipo = "Novela",
};

AudioLibros ab1 = new AudioLibros()
{
    titulo = "AudioLibro 1",
    narrador = "Narrador reconocio",
    formato = "mp4",
    editorial = "Editorial reconocida",
    duracion = 30,
    capitulos = 10,
    fechaPublicacion = new DateTime(2000, 05, 12),
};

JuegosMesa game1 = new JuegosMesa()
{
    titulo = "Monopoly",
    edad = 8,
    minJugadores = 2,
    maxJugadores = 6,
    fabricante = "Hasbro",
    fechaPublicacion = new DateTime(2000, 05, 12),
};

JuegosMesa game2 = new JuegosMesa()
{
    titulo = "Scrabble",
    edad = 12,
    minJugadores = 2,
    maxJugadores = 4,
    fabricante = "Mattel",
};

JuegosMesa game3 = new JuegosMesa()
{
    titulo = "Jenga",
    edad = 12,
    minJugadores = 2,
    maxJugadores = 5,
    fabricante = "Hasbro",
};

bienvenida.libros.Add(l1);
bienvenida.libros.Add(l2);
bienvenida.audioLibros.Add(ab1);
bienvenida.juegosMesa.Add(game1);
bienvenida.juegosMesa.Add(game2);
bienvenida.juegosMesa.Add(game3);

Console.WriteLine(bienvenida.bienvenida());
Console.WriteLine("=======Metodos de las peliculas=======");
Console.WriteLine(peli1.toString());

Console.WriteLine("=======Metodos de los libros=======");
Console.WriteLine(l1.toString());
Console.WriteLine(l1.pasarHoja());
Console.WriteLine(l2.toString());
Console.WriteLine(l2.pasarHoja() + "\n");

Console.WriteLine("=======Metodos de los AudioLibros=======");
Console.WriteLine(ab1.toString());
Console.WriteLine(ab1.siguienteCapitulo());


Console.WriteLine("=======Metodos de los Juegos de Mesa=======");
Console.WriteLine(game1.toString());