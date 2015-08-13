using System.Collections.Generic;

namespace Ctrl_Test.Models.ViewModels.Interfaces
{
	interface IEducationViewModel<TSchoolViewModel, TUniversityViewModel>
		where TSchoolViewModel : ISchoolViewModel
		where TUniversityViewModel: IUniversityViewModel
	{
		TSchoolViewModel School { get; set; }
		List<TUniversityViewModel> Universities { get; set; } 
		string CourseWork { get; set; }
	}
}
