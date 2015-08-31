using System.Collections.Generic;
using Ctrl_Test.Models.ViewModels;

namespace Ctrl_Test.Areas.CeMba.Models
{
    public class CeMbaEducationViewModel : BaseEducationViewMode<CeMbaEducationViewModel>
    {
        // some extra specific prop which is not in base educational model
        public string CeMbaExpreience { get; set; }

        // instanciate the base properties
        public CeMbaEducationViewModel()
        {
            School = new BaseSchoolViewModel();
            Universities = new List<BaseUniversityViewModel>
            {
                new BaseUniversityViewModel()
            };
            CourseWork = string.Empty;
        }
    }
}