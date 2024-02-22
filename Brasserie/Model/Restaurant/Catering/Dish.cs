using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Dish : Item
    {
        public Dish(string name, string description, int id, double unitPrice, double vatRate, string pictureName) : base(name, description, id, unitPrice, vatRate, pictureName)
        {
        }
    }
}
