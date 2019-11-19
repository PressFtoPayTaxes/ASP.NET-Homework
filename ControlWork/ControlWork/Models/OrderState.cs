using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWork.Models
{
    public enum OrderState
    {
        Free = 1,
        Taken,
        InProgress,
        Complete
    }
}
