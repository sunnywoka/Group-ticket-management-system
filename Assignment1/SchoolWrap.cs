using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class SchoolWrap : IDiscount
    {
        private SchoolGroup _SchoolGroup;

        public SchoolWrap(int PeopleNumber)
        {
            _SchoolGroup = new SchoolGroup();
            _SchoolGroup.Size = PeopleNumber;
        }

        public int PeopleNumber
        {
            get
            {
                return _SchoolGroup.Size;
            }
        }

        public double FindTotalPrice()
        {
            _SchoolGroup.GroupPrice = Price.Student;
            if (PeopleNumber >= 10)
            {
                return _SchoolGroup.ShowGroupPrice() * PeopleNumber * 0.8;
            }
            else
            {
                return _SchoolGroup.ShowGroupPrice() * PeopleNumber;
            }
        }

        public double Discount()
        {
            _SchoolGroup.GroupPrice = Price.Student;
            return _SchoolGroup.ShowGroupPrice() * PeopleNumber * 0.2;
        }
    }
}