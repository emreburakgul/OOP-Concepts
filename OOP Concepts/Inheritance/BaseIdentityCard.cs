using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Base: temel/alt
    // Java'da super class
    class BaseIdentityCard : Card
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SerialCode { get; set; }
    }
}
