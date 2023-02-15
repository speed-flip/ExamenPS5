namespace ExamenS5.models
{
    public class JuegosMesa : Recurso
    {
        public int edad { get; set; }
        public int minJugadores { get; set; }
        public int maxJugadores { get; set; }
        public string fabricante { get; set; }

        public override string toString()
        {
            return $"El juego {base.titulo} fabricado por {fabricante} requiere una edad minima de {edad} años para jugar " +
                $"y requiere entre {minJugadores} y {maxJugadores} jugadores \n publicado: {base.fechaPublicacion}";
        }

    }
}
