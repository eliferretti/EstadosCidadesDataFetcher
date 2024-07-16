using EstadosCidadesDataFetcher.Entities;
using System.Net.Http.Json;
using System.Linq;

namespace EstadosCidadesDataFetcher
{
    static class Seed
    {
        public static async Task<List<Estado>> ObterEstados() 
        {
            var httpClient = new HttpClient();
            var estados = await httpClient.GetFromJsonAsync<List<Estado>>($"https://servicodados.ibge.gov.br/api/v1/localidades/estados");
            return estados ?? new List<Estado>();
        }

        public static async Task<List<Cidade>> ObterCidadesPorEstados(List<Estado> estados) 
        {
            List<Cidade> cidades = new();
            var httpClient = new HttpClient();
            foreach (var estado in estados) 
            {
                var responseCidades = await httpClient.GetFromJsonAsync<List<Cidade>>($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{estado.Id}/municipios");
                cidades.AddRange(from cidade in responseCidades
                                 select cidade);
            }
            return cidades;
        }
    }
}
