using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDI.InterfaceConfiguration.Sample
{
    /// <summary>
    /// Step 2 : Interface Implementation
    /// </summary>
    public class Sample : ISample
    {
        public string SampleHello()
        {
            return ("Hello");
        }
    }
}
