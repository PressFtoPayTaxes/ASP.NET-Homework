using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVCCoreVsMVCFrameworkComparison.Models
{
    public class Portfolio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string EducationalInstitution { get; set; }
        public string WorkPlace { get; set; }
        public string Job { get; set; }
        public string Achievements { get; set; }
        public IEnumerable<string> WorkExamples { get; set; } = new List<string>();
    }
}
