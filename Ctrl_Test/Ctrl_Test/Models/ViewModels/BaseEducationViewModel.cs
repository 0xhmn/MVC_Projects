using System;
using System.Collections.Generic;
using Ctrl_Test.Models.ViewModels.Interfaces;

namespace Ctrl_Test.Models.ViewModels
{
	public class BaseEducationViewMode<T> : IEducationViewModel<BaseSchoolViewModel, BaseUniversityViewModel> , IEverythingShouldHave<T>
	{
		public BaseSchoolViewModel School { get; set; }
		public List<BaseUniversityViewModel> Universities { get; set; }
		public string CourseWork { get; set; }

		public T PopulateFromApplication(string db, int id)
		{
			throw new NotImplementedException();
		}

		public T PersistByApplication(string db, int id)
		{
			throw new NotImplementedException();
		}
	}
}
