using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class TourWrap : IDiscount
    {
        private TourGroup _TourGroup;

        public TourWrap(int PeopleNumber)
        {
            _TourGroup = new TourGroup();
            _TourGroup.Size = PeopleNumber;
        }


        public int PeopleNumber
        {
            get
            {
                return _TourGroup.Size;
            }
        }

        public double FindTotalPrice()
        {
            _TourGroup.GroupPrice = Price.Tourist;
            if (PeopleNumber >= 10)
            {
                return _TourGroup.ShowGroupPrice() * PeopleNumber * 0.9;
            }
            else
            {
                return _TourGroup.ShowGroupPrice() * PeopleNumber;
            }
        }

        public double Discount()
        {
            _TourGroup.GroupPrice = Price.Tourist;
            return _TourGroup.ShowGroupPrice() * PeopleNumber * 0.1;
        }
    }
}