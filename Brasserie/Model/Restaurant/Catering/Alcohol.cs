using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    public class Alcohol : Drink
    {
        const double MIN_ALCOHOL = 0.0;
        const double MAX_ALCOHOL = 100.0;

        private double _percentage;
        private bool _isNa;

        public Alcohol(string name, string description, int id, double unitPrice, double vatRate, string pictureName, double volume, double percentage, bool isNa) : base(name, description, id, unitPrice, vatRate, pictureName, volume)
        {
            Percentage = percentage;
            EvalNa();
        }

        private double Percentage
        {
            get => _percentage;
            set
            {
                if (CheckDegreePercentage(value))
                {
                    _percentage = value;
                    EvalNa();
                }
            }
        }

        private bool IsNa
        {
            get => _isNa;
            set =>_isNa = value;
                           
        }
        /// <summary>
        /// Check alcohol degree percentage
        /// </summary>
        /// <param name="degreePercentage"></param>
        /// <returns></returns>
        private static bool CheckDegreePercentage(double degreePercentage)
        {
            return degreePercentage >= MIN_ALCOHOL && degreePercentage <= MAX_ALCOHOL;

        }

        private void EvalNa()
        {
            IsNa = Percentage == 0;
        }

    }
}
