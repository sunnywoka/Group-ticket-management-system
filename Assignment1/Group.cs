using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public abstract class Group
    {
        private string _name;
        private int _size;
        private Price _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Size
        {
            get 
            {
                return _size;
            }
            set
            {
                _size = value;
            }
           
        }

        public virtual string GroupName()
        {
            throw new System.NotImplementedException();
        }

        public virtual int GroupSize()
        {
            throw new System.NotImplementedException();
        }

        public Price GroupPrice
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }

        }

        public int ShowGroupPrice()
        {
            return Convert.ToInt16(_price);
        }
    }
}