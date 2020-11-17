using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModels
{
    public class SkillViewModel:BaseViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public List<TechnologyViewModel> TechnologyViewModels { get; set; }
    }
}
