using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.RequestModel
{
    public class TestRequestModel
    {
        public string FullName { get; set; }
        public int Location { get; set; }
        public List<int> TechnologyId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
