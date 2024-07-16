namespace EstadosCidadesDataFetcher.Entities
{
    public class UF
    {
        public int Id { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public Regiao Regiao { get; set; } = new Regiao();
    }
}
