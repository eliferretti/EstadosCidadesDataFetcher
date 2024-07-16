using EstadosCidadesDataFetcher.Entities;

namespace EstadosCidadesDataFetcher.Helpers
{
    public class GerarSqlHelper
    {
        public void GerarSqlEstados(List<Estado> estados) 
        {
            using (var writer = new StreamWriter("estados.sql")) 
            {
                foreach (var estado in estados)
                {
                    writer.WriteLine($"INSERT INTO Estados (Id, Nome, Sigla) VALUES ({estado.Id}, '{estado.Nome.Replace("'", "''")}', '{estado.Sigla.Replace("'", "''")}');");
                }
            }
            Console.WriteLine("Arquivo estados.sql gerado com sucesso!");
        }
        public void GerarSqlCidades(List<Cidade> cidades) 
        {
            using (var writer = new StreamWriter("cidades.sql"))
            {
                foreach (var cidade in cidades)
                {
                    writer.WriteLine($"INSERT INTO Cidades (Id, Nome, EstadoId) VALUES ({cidade.Id}, '{cidade.Nome.Replace("'", "''")}', {cidade.Microrregiao.Mesorregiao.UF.Id});");
                }
            }
            Console.WriteLine("Arquivo cidades.sql gerado com sucesso!");
        }
    }
}
