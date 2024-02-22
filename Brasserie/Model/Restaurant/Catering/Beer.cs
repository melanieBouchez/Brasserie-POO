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

        public Beer(string name, string description, int id, double unitPrice, double vatRate, string pictureName, double volume, double percentage, bool isAbbeyBeer, bool isTrapistBeer) : base(name, description, id, unitPrice, vatRate, pictureName, volume, percentage)
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
