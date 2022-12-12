using Microsoft.AspNetCore.Mvc;
using reports_cocha_api.Data;
using reports_cocha_api.Models;

namespace reports_cocha_api.Controllers
{
    [ApiController]
    [Route("report")]
    public class ReportController: ControllerBase 
    {
        [HttpGet]
        [Route("findAll")]
        public async Task <ActionResult<List<Report>>> getAll()
        {
            var function = new DataReports();
            var list = await function.ShowReports();
            return list;
        }
        /*
		[HttpPost]
		[Route("post")]
		public dynamic save()
		{
		}
        */
	}
}
