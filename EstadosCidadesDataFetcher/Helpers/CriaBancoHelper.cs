using Microsoft.Data.Sqlite;

namespace EstadosCidadesDataFetcher.Helpers
{
    public class CriaBancoHelper
    {
        public void CriaBanco() 
        {
            var connectionString = "Data Source=sample.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Estado (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        DataCadastro DATETIMEOFFSET NOT NULL, 
                        DataUltimaAlteracao DATETIMEOFFSET NOT NULL, 
                        Nome TEXT NOT NULL,
                        Sigla NOT NULL
                    )";
                createTableCmd.ExecuteNonQuery();

                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Cidade (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        DataCadastro DATETIMEOFFSET NOT NULL, 
                        DataUltimaAlteracao DATETIMEOFFSET NOT NULL, 
                        Nome TEXT NOT NULL,
                        EstadoId INTEGER NOT NULL
                    )";
                createTableCmd.ExecuteNonQuery();
            }   
        }
    }
}
