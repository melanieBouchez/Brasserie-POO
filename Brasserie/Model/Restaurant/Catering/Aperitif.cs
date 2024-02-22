using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Aperitif : Alcohol
    {
        public Aperitif(string name, string description, int id, double unitPrice, double vatRate, string pictureName, double volume, double percentage, bool isNa) : base(name, description, id, unitPrice, vatRate, pictureName, volume, percentage, isNa)
        {
        }
    }
}
