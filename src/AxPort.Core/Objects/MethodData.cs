using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxPort.Core.Objects
{
    public sealed class MethodData
    {
        public string Name { get; }

        public string MethodBody { get; }

        public string XmlDoc { get; }

        internal MethodData(string name, string methodBody, string xmlDoc)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            this.Name = name;
            this.MethodBody = methodBody ?? string.Empty;
            this.XmlDoc = xmlDoc ?? string.Empty;
        }
    }
}
