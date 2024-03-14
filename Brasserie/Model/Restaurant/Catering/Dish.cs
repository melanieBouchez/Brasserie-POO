using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Dish : Item
    {
        public Dish(int id, string name, string description,  double unitPrice, string pictureName, double vatRate) : base(id, name, description, unitPrice, vatRate, pictureName)
        {
        }
    }
}
