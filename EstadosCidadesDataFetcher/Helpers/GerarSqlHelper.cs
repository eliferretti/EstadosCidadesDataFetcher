using EstadosCidadesDataFetcher.Entities;

namespace EstadosCidadesDataFetcher.Helpers
{
    public class GerarSqlHelper
    {
        public void GerarSqlEstados(List<Estado> estados) 
        {
            using (var writer = new StreamWriter("estado.sql")) 
            {
                foreach (var estado in estados)
                {
                    writer.WriteLine($"INSERT INTO Estado (Nome, Sigla) VALUES ('{estado.Nome.Replace("'", "''")}', '{estado.Sigla.Replace("'", "''")}');");
                }
            }
            Console.WriteLine("Arquivo estado.sql gerado com sucesso!");
        }
        public void GerarSqlCidades(List<Cidade> cidades) 
        {
            using (var writer = new StreamWriter("cidade.sql"))
            {
                foreach (var cidade in cidades)
                {
                    writer.WriteLine($"INSERT INTO Cidade (Nome, EstadoId) VALUES ('{cidade.Nome.Replace("'", "''")}', SELECT Id FROM Estado WHERE Sigla = '{cidade.Microrregiao.Mesorregiao.UF.Sigla.Replace("'", "''")}');"); 
                }
            }
            Console.WriteLine("Arquivo cidade.sql gerado com sucesso!");
        }
    }
}
