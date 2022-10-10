using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.PizzaSystem
{
    public class Pizza
    {
        public Pizza(string _title, string _desc)
        {
            Title = _title;
            Description = _desc;
        }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
