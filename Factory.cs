using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class Factory
    {
        public bool Type { get; set; }
        public Factory() { }
        public Factory(bool type)
        {
            Type = type;
        }
    }
}
