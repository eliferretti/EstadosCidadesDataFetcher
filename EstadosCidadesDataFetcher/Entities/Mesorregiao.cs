namespace EstadosCidadesDataFetcher.Entities
{
    public class Mesorregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public UF UF { get; set; } = new UF();
    }
}
