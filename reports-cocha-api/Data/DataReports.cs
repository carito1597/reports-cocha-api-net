using System.Data.SqlClient;
using reports_cocha_api.Conection;
using reports_cocha_api.Models;

namespace reports_cocha_api.Data
{
    public class DataReports
    {
        ConectionDb cn = new ConectionDb();
        public async Task <List<Report>> ShowReports()
        {
            var list = new List<Report>();
            using (var sql = new SqlConnection(cn.stringSQL()))
            {
                using(var cmd = new SqlCommand("showReports", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using(var item = await cmd.ExecuteReaderAsync())
                    {
                        while(await item.ReadAsync())
                        {
                            var report = new Report();
                            report.idReport = (int)item["idReport"];
                            report.description = (string)item["description"];
                            report.problem = (string)item["problem"];
                            report.latitude = (string)item["latitude"];
                            report.longitude = (string)item["longitude"];
                            list.Add(report);
                        }
                    }
                }
            }
            return list;
        }
    }
}
