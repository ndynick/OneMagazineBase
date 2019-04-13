using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{
    public partial class SchoolSubscriptionForm : Happy_Magazines_Subscription.BaseForm 
    {
        public SchoolSubscriptionForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisplaySchool goDisplaySchool = new DisplaySchool();
            goDisplaySchool.ShowDialog();
            
        }

        private void btnAddSch_Click(object sender, EventArgs e)
        {
           
            string cardType = "";
            string magType = "";
            decimal subscriptionAfterDISCOUNT = 0m;
            decimal subscriptionAfterREBATE = 0m;
            int years;
            decimal discountRate=0;
            int subscriptionCount=0;
            decimal subscriptionTotal=0;

            int index;
            index = Program.getNextSchIndex();
            if (index >= Program.maxSch)  // no more null position to store salesman
            {
                MessageBox.Show("Reached maximum subscriptions");
                return;
            }


            //Validation for SchoolID textbox
            if (txtSchoolID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your ID");
                txtSchoolID.Focus();
                return;
            }

            if (Program.getSchIdIndex(txtSchoolID.Text) < Program.maxSch) // ID exists in array
            {
                MessageBox.Show("ID has already been taken. Please enter a different ID");
                txtSchoolID.Focus();
                return;
            }


            //Validation #1 for Name textbox
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Name");
                txtName.Focus();
                return;
            }

            //Validation #2 for Name textbox
            if (txtName.Text.Contains("0") == true || txtName.Text.Contains("1") == true || txtName.Text.Contains("2") == true || txtName.Text.Contains("3") == true
                || txtName.Text.Contains("4") == true || txtName.Text.Contains("5") == true || txtName.Text.Contains("6") == true || txtName.Text.Contains("7") == true
                || txtName.Text.Contains("8") == true || txtName.Text.Contains("9") == true)
     
            {
                MessageBox.Show("Name cannot be integer");
                txtName.Focus();
                return;
            }


            //Validation #1 for Contact No textbox
            int contactNo;

            try
            {
                contactNo = int.Parse(txtContact.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Number must be in integer");
                txtContact.Focus();
                return;
            }

            //Validation #2 for Contact No textbox
            if (txtContact.TextLength < 8)
            {
                MessageBox.Show("Contact Number must be in 8 digit numbers");
                txtContact.Focus();
                return;
            }


            //Validation #1 for Email textbox
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Email address");
                txtEmail.Focus();
                return;
            }

            //Validation #2 for Email textbox
            bool email = txtEmail.Text.Contains("@");
            bool email2 = txtEmail.Text.Contains(" ");

            if (email == false)
            {
                MessageBox.Show("Email must have @","Invalid email address");
                txtEmail.Focus();
                return;
            }

            else if (email2 == true)
            {
                MessageBox.Show("Email cannot have blank in between the email address.","Invalid email address");
                txtEmail.Focus();
                return;
            }


            //Validation for Address textbox
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Address");
                txtAddress.Focus();
                return;
            }


            //Validation #1 for Year textbox
            if (txtYear.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Subscription Year");
                txtYear.Focus();
                return;
            }

            //Validation #2 for Year textbox
            try
            {
                years = int.Parse(txtYear.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter an integer");
                txtYear.Focus();
                return;
            }

            //Validation for Magazines and Payment Card radiobuttons
            if ((rdoTeenage.Checked == true || rdoSeventeen.Checked || rdoEmpire.Checked || rdoEspn.Checked)
                && (rdoVisa.Checked == true || rdoMaster.Checked == true || rdoAE.Checked == true || rdoKrisflyer.Checked))

            {
                //Total subscription after 1.25% discount
                if (rdoTeenage.Checked == true)
                {
                    subscriptionAfterDISCOUNT = SchoolSubscriber.calculateFinalSubscriptionAmount(80m, int.Parse(txtYear.Text));
                    magType = rdoTeenage.Text;
                }
                else if (rdoSeventeen.Checked == true)
                {
                    subscriptionAfterDISCOUNT = SchoolSubscriber.calculateFinalSubscriptionAmount(95m, int.Parse(txtYear.Text));
                    magType = rdoSeventeen.Text;
                }
                else if (rdoEmpire.Checked == true)
                {
                    subscriptionAfterDISCOUNT = SchoolSubscriber.calculateFinalSubscriptionAmount(80m, int.Parse(txtYear.Text));
                    magType = rdoEmpire.Text;
                }
                else if (rdoEspn.Checked == true)
                {
                    subscriptionAfterDISCOUNT = SchoolSubscriber.calculateFinalSubscriptionAmount(95m, int.Parse(txtYear.Text));
                    magType = rdoEspn.Text;
                }
               
                //Total subscription after 0.5% rebate
                subscriptionAfterREBATE = subscriptionAfterDISCOUNT - (subscriptionAfterDISCOUNT * SchoolSubscriber.rebateDecimal);


                //Card payment types
                if (rdoVisa.Checked == true)
                {
                    cardType = rdoVisa.Text;
                }
                else if (rdoMaster.Checked == true)
                {
                    cardType = rdoMaster.Text;
                }
                else if (rdoAE.Checked == true)
                {
                    cardType = rdoAE.Text;
                }
                else if (rdoKrisflyer.Checked == true)
                {
                    cardType = rdoKrisflyer.Text;
                }
                

                    //MessageBox to show the user all the School Subscription Detail
                    MessageBox.Show("[School Subscription Detail]" + Environment.NewLine 
                    + "-School ID: " + txtSchoolID.Text + Environment.NewLine
                    + "-Name: " + txtName.Text + Environment.NewLine
                    + "-Contact No: " + txtContact.Text + Environment.NewLine
                    + "-E-Mail: " + txtEmail.Text + Environment.NewLine
                    + "-Address: " + txtAddress.Text + Environment.NewLine
                    + "-Date: " + dateTimePickerSch.Text + Environment.NewLine
                    + "-Subscription Years: " + years + Environment.NewLine
                    + "-Magazine: " + magType + Environment.NewLine
                    + "-Payment Method: " + cardType + Environment.NewLine
                    + "-Total price after discount: " + subscriptionAfterDISCOUNT.ToString("C") + Environment.NewLine
                    + "-Total price after rebate: " + subscriptionAfterREBATE.ToString("C") + Environment.NewLine);


            }
            else
            {
                MessageBox.Show("Please fill in subscription details");
                return;
            }

            
            Program.schArray[index] = new SchoolSubscriber(txtSchoolID.Text, txtName.Text, contactNo, txtEmail.Text, txtAddress.Text, dateTimePickerSch.Text, years, magType, cardType, discountRate, subscriptionCount, subscriptionTotal, subscriptionAfterDISCOUNT, subscriptionAfterREBATE);
            MessageBox.Show("New subscription recorded","New Record");

            //Clear all the textbox and radiobuttons after add into the array
            txtName.Text = "";
            txtSchoolID.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtYear.Text = "";
            rdoTeenage.Checked = false;
            rdoSeventeen.Checked = false;
            rdoEmpire.Checked = false;
            rdoEspn.Checked = false;
            rdoVisa.Checked = false;
            rdoMaster.Checked = false;
            rdoAE.Checked = false;
            rdoKrisflyer.Checked = false;

            //Focus on the School ID textbox
            txtSchoolID.Focus();
        }
    }
}
