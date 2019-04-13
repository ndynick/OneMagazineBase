using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{
    public partial class DisplaySchool : Happy_Magazines_Subscription.BaseForm
    {
        public DisplaySchool()
        {
            InitializeComponent();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayAll goDisplayAll = new DisplayAll();
            goDisplayAll.ShowDialog();
        }

        private void DisplaySchool_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.maxSch; i++)
            {
                if (Program.schArray[i] != null)
                {
                    listSchool.Items.Add("<[School ID: " + Program.schArray[i].ID + " ] "
                        + "[Name: " + Program.schArray[i].getName() + " ] "
                        + "[Contact No: " + Program.schArray[i].CONTACTNO + " ] "
                        + "[Email: " + Program.schArray[i].EMAIL + " ] "
                        + "[Address: " + Program.schArray[i].ADDRESS + " ] "
                        + "[Date: " + Program.schArray[i].DATE + " ] "
                        + "[Subscription Years: " + Program.schArray[i].getNoOfYear() + " ] "
                        + "[Magazine: " + Program.schArray[i].getmagazineString() + " ] "
                        + "[Payment Method: " + Program.schArray[i].getCardTypeString() + " ] "
                        + "[Total price after discount: " + Program.schArray[i].getSubAfterDiscount().ToString("C") + " ] "
                        + "[Total price after rebate: " + Program.schArray[i].getSubAfterRebate().ToString("C") + " ]> ");
                }
            }

            listSchool.HorizontalScrollbar = true;
        }
    }
}
