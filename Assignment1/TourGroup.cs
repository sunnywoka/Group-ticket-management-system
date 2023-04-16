using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class TourGroup : Group
    {

        
        public override string GroupName()
        {
            return this.Name;
        }

        public override int GroupSize()
        {
            return this.Size;
        }
    }
}