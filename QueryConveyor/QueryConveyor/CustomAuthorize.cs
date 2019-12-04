using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryConveyor
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorize : System.Attribute
    {

    }
}
