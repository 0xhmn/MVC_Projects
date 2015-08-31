using System.Collections.Generic;

namespace Ctrl_Test.Models.ViewModels
{
    public class ProgramSelectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> OpenTerms { set; get; } 
    }
}