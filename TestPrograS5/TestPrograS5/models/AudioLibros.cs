namespace ExamenS5.models
{
    public class AudioLibros : Recurso, IAudioLibro
    {
        public string narrador { get; set; }
        public string formato { get; set; }
        public string editorial { get; set;}
        public int duracion { get; set; }
        public int capitulos { get; set; }

        public string siguienteCapitulo()
        {
            return "Reproduciendo el siguiente capitulo";
        }

        public override string toString()
        {
            return $"El AudioLibro {base.titulo} fue narrado por {narrador} - " +
                $"tiene {capitulos} capitulos con una duracion de {duracion} minutos en formato {formato} " +
                $"publicada por la editorial {editorial}\n";
        }
    }
}
