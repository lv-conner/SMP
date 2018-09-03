using System;
using System.Collections.Generic;
using System.Text;

namespace SMP.ApplicationContext
{
    public class ApplicationUser:EntityBase
    {
        public string Name { get; protected set; }
    }
}
