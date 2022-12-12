using System.ComponentModel.DataAnnotations;

namespace reports_cocha_api.Models
{
    public class Report
    {
		[Key]
		public int idReport { get; set; }
		public string problem { get; set; }
		public string description { get; set; }
		public string latitude { get; set; }
		public string longitude { get; set; }

	}
}
