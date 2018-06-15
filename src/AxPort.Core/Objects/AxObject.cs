using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxPort.Core.Objects
{
    public abstract class AxObject
    {
        public string Declaration { get; }

        public string ToString(AxVersion axVersion)
        {
            switch (axVersion)
            {
                case AxVersion.Ax2012:
                    return ToAx2012String();
                case AxVersion.Ax365:
                    return ToAx365String();
                default:
                    throw new ArgumentOutOfRangeException(nameof(axVersion));
            }
        }

        protected abstract string ToAx2012String();

        protected abstract string ToAx365String();

        internal AxObject()
        {

        }
    }
}
