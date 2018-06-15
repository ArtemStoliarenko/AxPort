using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxPort.Core.Objects
{
    public abstract class AxExecutableObject : AxObject
    {
        public MethodData[] Methods { get; } = new MethodData[0];
    }
}
