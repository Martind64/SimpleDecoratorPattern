using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoraterPattern
{
    public class Pineapple : DecoratorClass
    {
        public Pineapple(PizzaComponent _component) : base (_component)
        {
            _name = "Pineapple";
            _price = 1.00m;
        }
    }
}
