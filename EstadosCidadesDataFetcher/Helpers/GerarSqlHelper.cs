using EstadosCidadesDataFetcher.Entities;

namespace EstadosCidadesDataFetcher.Helpers
{
    public class GerarSqlHelper
    {
        public void GerarSqlEstados(List<Estado> estados) 
        {
            using (var writer = new StreamWriter("1-SP174-estado.sql")) 
            {
                foreach (var estado in estados)
                {
                    writer.WriteLine($"INSERT INTO imobiliario.Estado (DataCadastro, DataUltimaAlteracao, Nome, Sigla) VALUES (SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET(), '{estado.Nome.Replace("'", "''")}', '{estado.Sigla.Replace("'", "''")}');");
                }
            }
            Console.WriteLine("Arquivo estado gerado com sucesso!");
        }
        public void GerarSqlCidades(List<Cidade> cidades) 
        {
            using (var writer = new StreamWriter("2-SP174-cidade.sql"))
            {
                foreach (var cidade in cidades)
                {
                    writer.WriteLine($"INSERT INTO imobiliario.Cidade (DataCadastro, DataUltimaAlteracao, Nome, EstadoId) VALUES (SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET(), '{cidade.Nome.Replace("'", "''")}', (SELECT Id FROM imobiliario.Estado WHERE Sigla = '{cidade.Microrregiao.Mesorregiao.UF.Sigla.Replace("'", "''")}'));"); 
                }
            }
            Console.WriteLine("Arquivo cidade gerado com sucesso!");
        }
    }
}
