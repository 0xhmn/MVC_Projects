using Ctrl_Test.Models.ViewModels.Interfaces;

namespace Ctrl_Test.Models.ViewModels
{
	public class BaseUniversityViewModel : IUniversityViewModel
	{
		public string Location { get; set; }
		public string Major { get; set; }
	}
}
