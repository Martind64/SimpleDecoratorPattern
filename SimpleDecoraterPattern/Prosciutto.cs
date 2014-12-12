using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoraterPattern
{
    public class Prosciutto : DecoratorClass
    {

        public Prosciutto(PizzaComponent _component) : base (_component)
        {
            _name = "Prosciutto";
            _price = 1.00m;
        }

    }
}
