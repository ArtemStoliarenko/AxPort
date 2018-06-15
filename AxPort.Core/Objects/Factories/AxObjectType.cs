using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxPort.Core.Objects.Factories
{
    enum AxObjectType
    {
        None = 0,
        Table,
        Map,
        View,
        Macros,
        Class,
        Form,
        Query,
        Job
    }
}
