using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoraterPattern
{
    public abstract class PizzaComponent
    {
        public abstract string Name{get;}
        public abstract decimal Price { get; }

    }
}
