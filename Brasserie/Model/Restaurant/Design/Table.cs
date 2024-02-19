using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Design
{
    public class Table
    {
        const int MIN_SEATS = 2;

        const int MIN_ID = 1;
        const int primaryKey = 30;

        private int _seatsNumber;
        private int _idNumber;
        private bool _isNowBusy;
        
        private static int _totalSeats;

        public Table (int seatsNumber, int idNumber, bool isNowBusy)
        {
            SeatsNumber = seatsNumber;
            IdNumber = idNumber;
            IsNowBusy = isNowBusy;
            TotalSeats+= SeatsNumber;
        }
        //public Table() { }

        public int SeatsNumber
        {
            get => _seatsNumber;

            set
            {
                if (CheckSeatsNumber(value))
                {
                    _seatsNumber = value;
                }
            }

        }

        public int IdNumber
        {
            get => _idNumber;
            set
            {
                if (CheckIdNumber(value))
                {
                    _idNumber = value;
                }
            }
        }
        public bool IsNowBusy
        {
            get => _isNowBusy;
            set => _isNowBusy = value;
        }

        public static int TotalSeats
        {
            get => _totalSeats;
            set => _totalSeats = value;
        }

        private bool CheckSeatsNumber(int seatsNumber)
        {              
            return seatsNumber >= MIN_SEATS;
        }

        static public bool CheckIdNumber (int idNumber)
        {
            return idNumber > MIN_ID;           
        }



    }
}
