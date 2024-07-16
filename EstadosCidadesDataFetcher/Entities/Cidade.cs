namespace EstadosCidadesDataFetcher.Entities
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Microrregiao Microrregiao { get; set; } = new Microrregiao();
    }
}
