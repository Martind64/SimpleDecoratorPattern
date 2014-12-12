using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoraterPattern
{
    public class BasePizza
    {
        private string _name = "Basic Pizza";
        private decimal _price;

        public  string Name
        {
            get { return _name; }
        }


        public decimal Price
        {
            get { return _price; }
        }
    }
}
