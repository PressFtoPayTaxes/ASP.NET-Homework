using AspNetMvcCoreVsMvcFrameworkComparison2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVCCoreVsMVCFrameworkComparison2.Models
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
        public virtual ICollection<WorkExample> WorkExamples { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
