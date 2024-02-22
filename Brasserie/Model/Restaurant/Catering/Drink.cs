using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Drink : Item
    {
        const double MIN_VOLUME = 1.0;

        private double _volume;

        public Drink(string name, string description, int id, double unitPrice, double vatRate, string pictureName, double volume) : base(name, description, id, unitPrice, vatRate, pictureName)
        {
        }

        public double Volume
        {
            get => _volume;
            set
            {
                if (CheckMinVolume(value,MIN_VOLUME))
                {
                    _volume = value;
                }
                    
            }

        }

        private bool CheckMinVolume(double value, double min)
        {
            return value >= min;
        }
    }
}
