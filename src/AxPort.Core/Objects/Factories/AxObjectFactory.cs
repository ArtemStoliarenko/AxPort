using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxPort.Core.Objects.Factories
{
    abstract class AxObjectFactory
    {
        public AxObject CreateAxObject(string source, AxVersion axVersion)
        {
            switch (axVersion)
            {
                case AxVersion.Ax2012:
                    return CreateAxObjectFromAx2012Source(source);
                case AxVersion.Ax365:
                    return CreateAxObjectFromAx365Source(source);
                default:
                    throw new ArgumentOutOfRangeException(nameof(axVersion));
            }
        }

        public abstract AxObjectType ObjectType { get; }

        protected abstract AxObject CreateAxObjectFromAx2012Source(string source);

        protected abstract AxObject CreateAxObjectFromAx365Source(string source);
    }
}
