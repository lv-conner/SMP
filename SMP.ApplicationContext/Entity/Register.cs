using System;
using System.Collections.Generic;
using System.Text;

namespace SMP.ApplicationContext.Entity
{
    public class Register:EntityBase
    {
        private Register()
        {

        }
        public Register(DateTime registerDate)
        {
            RegisterDate = registerDate;
        }
        public DateTime? RegisterDate { get; protected set; }
    }
}
