using Ctrl_Test.Models.ViewModels.Interfaces;

namespace Ctrl_Test.Models.ViewModels
{
	public class BaseSchoolViewModel : ISchoolViewModel
	{
		public string SchoolName { get; set; }
		public string SchoolLocation { get; set; }
	}
}
