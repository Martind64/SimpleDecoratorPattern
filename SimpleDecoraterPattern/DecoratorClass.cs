using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoraterPattern
{
    public abstract class DecoratorClass : PizzaComponent
    {


        protected PizzaComponent _Component;
        protected string _name = "";
        protected decimal _price = 0m;

        protected DecoratorClass(PizzaComponent component)
        {
            _Component = component;
        }


        public override string Name
        {
            get { return string.Format("{0}, {1}", _Component.Name, _name); }
        }

        public override decimal Price
        {
            get { return _Component.Price + Price; }
        }

        public virtual PizzaComponent InnerComponent
        {
            get { return _Component; }
        }
    }
}
