using EstadosCidadesDataFetcher;
using EstadosCidadesDataFetcher.Helpers;

var sqlHelper = new GerarSqlHelper();
var estados = await Seed.ObterEstados();
var cidades = await Seed.ObterCidades(estados);

sqlHelper.GerarSqlEstados(estados);
sqlHelper.GerarSqlCidades(cidades);

var bancoHelper = new CriaBancoHelper();
bancoHelper.CriaBanco();

Console.WriteLine("Fim da aplicação!!");
Console.ReadLine();