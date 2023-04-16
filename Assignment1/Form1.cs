using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IDiscount _obj;
        //private Group _groupType;
        private Price _price;

        private void button_calculate_Click(object sender, EventArgs e)
        {
            string Name = textBoxNameGroup.Text;
            int Size = Convert.ToInt32(textBoxSize.Text);

            if (_price == Price.Student)
            {
                _obj = new SchoolWrap(Size);
            } 
            else
            {
                _obj = new TourWrap(Size);  
            }

            lblGroupName.Text = Name;
            lblGroupSize.Text = Size.ToString();
            lblTotalPrice.Text = Convert.ToString(_obj.FindTotalPrice());
            lblTotalDiscount.Text = (_obj.Discount()).ToString();
        }

        private void radioButtonSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSchool.Checked)
            {
                _price = Price.Student;
            }
            
        }

        private void radioButtonTour_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTour.Checked)
            {
                _price = Price.Tourist;
            }

        }

        
    }
}
