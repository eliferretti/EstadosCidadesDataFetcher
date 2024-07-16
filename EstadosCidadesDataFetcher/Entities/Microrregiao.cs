namespace EstadosCidadesDataFetcher.Entities
{
    public class Microrregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Mesorregiao Mesorregiao { get; set; } = new Mesorregiao();
    }
}
