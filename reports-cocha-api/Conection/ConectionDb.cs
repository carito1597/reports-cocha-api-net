namespace reports_cocha_api.Conection
{
    public class ConectionDb
    {
        private string connectionString = string.Empty;
        public ConectionDb()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            connectionString = builder.GetSection("ConnectionStrings:masterConection").Value;

        }
        public string stringSQL()
        {
            return connectionString;
        }
    }
}
