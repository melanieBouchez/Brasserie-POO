using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Beer : Alcohol
    {
        private bool _isAbbeyBeer;
        private bool _isTrappistBeer;

        public Beer(int id, string name, string description, double unitPrice, string pictureName, double vatRate, double volume, double percentage, bool isAbbeyBeer, bool isTrapistBeer) : base(id, name, description,  unitPrice, vatRate, pictureName, volume, percentage)
        {
            IsAbbeyBeer = isAbbeyBeer;
            IsTrappistBeer = isTrapistBeer;
        }

        private bool IsAbbeyBeer
        {
            get => _isAbbeyBeer;
            set => _isAbbeyBeer = value;

        }

        private bool IsTrappistBeer
        {
            get => _isTrappistBeer;
            set => _isTrappistBeer = value;
        }

        
    }
}
