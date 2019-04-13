using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{
    public partial class DisplayAll : Happy_Magazines_Subscription.BaseForm
    {
        public DisplayAll()
        {
            InitializeComponent();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void DisplayAll_Load(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //To clear the items in listbox each time the btnShow is click
            listBoxDisplayALL.Items.Clear();
            

            if (rdoMemSubDetail.Checked)
            {
                //Display Member Subscription Detail
                for (int i = 0; i < Program.maxMemberSubscriber; i++)
                {
                    if (Program.eArray[i] != null)
                    {
                        listBoxDisplayALL.Items.Add("<[Member ID: " + Program.eArray[i].ID + " ] "
                                + "[Name: " + Program.eArray[i].getName() + " ] "
                                + "[Contact No: " + Program.eArray[i].CONTACTNO.ToString() + " ] "
                                + "[Email: " + Program.eArray[i].Email + " ] "
                                + "[Address: " + Program.eArray[i].Address + " ] "
                                + "[Date: " + Program.eArray[i].DATE + " ] "
                                + "[Subscription Years: " + Program.eArray[i].getNoOfYear() + " ] "
                                + "[Magazine: " + Program.eArray[i].getmagazineString() + " ] "
                                + "[Payment Method: " + Program.eArray[i].getCardTypeString() + " ] "
                                + "[Reward Points: " + Program.eArray[i].RewardPoints.ToString("N2") + " ] "
                                + "[Total price after discount: " + Program.eArray[i].getTotalAmount().ToString("C") + " ]> ");
                                
                    }
                }
                listBoxDisplayALL.HorizontalScrollbar = true;
            }
            else if (rdoSchSubDetail.Checked)
            {
                //Display School Subscription Detail
                for (int i = 0; i < Program.maxSch; i++)
                {
                    if (Program.schArray[i] != null)
                    {
                        
                            listBoxDisplayALL.Items.Add("<[School ID: " + Program.schArray[i].ID + " ] "
                                + "[Name: " + Program.schArray[i].getName() + " ] "
                                + "[Contact No: " + Program.schArray[i].CONTACTNO.ToString() + " ] "
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
                listBoxDisplayALL.HorizontalScrollbar = true;
            }
            else
            {
                //Display Member Subscription Detail
                for (int i = 0; i < Program.maxMemberSubscriber; i++)
                {
                    if (Program.eArray[i] != null)
                    {
                        listBoxDisplayALL.Items.Add("<[Member ID: " + Program.eArray[i].ID + " ] "
                                + "[Name: " + Program.eArray[i].getName() + " ] "
                                + "[Contact No: " + Program.eArray[i].CONTACTNO.ToString() + " ] "
                                + "[Email: " + Program.eArray[i].Email + " ] "
                                + "[Address: " + Program.eArray[i].Address + " ] "
                                + "[Date: " + Program.eArray[i].DATE + " ] "
                                + "[Subscription Years: " + Program.eArray[i].getNoOfYear() + " ] "
                                + "[Magazine: " + Program.eArray[i].getmagazineString() + " ] "
                                + "[Payment Method: " + Program.eArray[i].getCardTypeString() + " ] "
                                + "[Reward Points: " + Program.eArray[i].RewardPoints.ToString("N2") + " ] "
                                + "[Total price after discount: " + Program.eArray[i].getTotalAmount().ToString("C") + " ]> ");

                    }
                }
               

                //Display School Subscription Detail
                for (int i = 0; i < Program.maxSch; i++)
                {
                    if (Program.schArray[i] != null)
                    {
                        listBoxDisplayALL.Items.Add("<[School ID: " + Program.schArray[i].ID + " ] "
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
                listBoxDisplayALL.HorizontalScrollbar = true;
            }
        }

        private void btnDeleteMem_Click(object sender, EventArgs e)
        {
            if (txtDelMemberID.Text.Trim() == "")
            {
                MessageBox.Show("Member ID cannot be blank", "Error");
                txtDelMemberID.Focus();
                return;
            }

            var result = MessageBox.Show("Member ID " + txtDelMemberID.Text + " will be deleted permanently! "
                + "Are you sure you really want to delete?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Dialog box
            if (result == DialogResult.Yes)
            {
                if (Program.getIdIndex(txtDelMemberID.Text) < Program.maxMemberSubscriber)
                {
                    MessageBox.Show("Member ID "
                        + Program.eArray[Program.getIdIndex(txtDelMemberID.Text)].ID
                        + " is deleted!", "Delete Member Subscriber");
                    Program.eArray[Program.getIdIndex(txtDelMemberID.Text)] = null;

                    txtMemberID.Text = "";
                    txtMemName.Text = "";
                    txtMemContact.Text = "";
                    txtMemEmail.Text = "";
                    txtMemAddress.Text = "";

                    txtMemberID.Enabled = true;
                    txtMemberID.Focus();
                    txtDelMemberID.Clear();

                    return;

                }
                else
                {
                    MessageBox.Show("Member ID does not exist", "Error");
                    txtDelMemberID.Clear();
                    txtDelMemberID.Focus();
                    return;
                }
            }
            else
            {

            }
        }

        private void btnDelSch_Click(object sender, EventArgs e)
        {
            
            if (txtDelSchoolID.Text.Trim() == "")
            {
                MessageBox.Show("School ID cannot be blank", "Error");
                txtDelSchoolID.Focus();
                return;
            }

            var result = MessageBox.Show("School ID " + txtDelSchoolID.Text + " will be deleted permanently! "
                + "Are you sure you really want to delete?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Dialog box
            if (result == DialogResult.Yes)
            {

                if (Program.getSchIdIndex(txtDelSchoolID.Text) < Program.maxSch)
                {
                    MessageBox.Show("School ID "
                        + Program.schArray[Program.getSchIdIndex(txtDelSchoolID.Text)].ID
                        + " is deleted!", "Delete School Subscriber");
                    Program.schArray[Program.getSchIdIndex(txtDelSchoolID.Text)] = null;

                    txtSchoolID.Text = "";
                    txtSchName.Text = "";
                    txtSchContact.Text = "";
                    txtSchEmail.Text = "";
                    txtSchAddress.Text = "";

                    txtSchoolID.Enabled = true;
                    txtSchoolID.Focus();
                    txtDelSchoolID.Clear();
                    return;

                }
                else 
                {
                    MessageBox.Show("School ID does not exist", "Error");
                    txtDelSchoolID.Clear();
                    txtDelSchoolID.Focus();
                    return;
                }
            }
            else 
            {
            }
            
        }

        private void btnEditSch_Click(object sender, EventArgs e)
        {
            //Validation for SchoolID textbox
            if (txtSchoolID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your School ID");
                txtSchoolID.Focus();
                return;
            }

            //Validation for Name textbox
            if (txtSchName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Name");
                txtSchName.Focus();
                return;
            }

            if (txtSchName.Text.Contains("0") == true || txtSchName.Text.Contains("1") == true || txtSchName.Text.Contains("2") == true || txtSchName.Text.Contains("3") == true
            || txtSchName.Text.Contains("4") == true || txtSchName.Text.Contains("5") == true || txtSchName.Text.Contains("6") == true || txtSchName.Text.Contains("7") == true
            || txtSchName.Text.Contains("8") == true || txtSchName.Text.Contains("9") == true)
            {
                MessageBox.Show("Name cannot be integer");
                txtSchName.Focus();
                return;
            }

            //Validation for Contact No textbox
            int contactNo;

            try
            {
                contactNo = int.Parse(txtSchContact.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Number must be in integer");
                txtSchContact.Focus();
                return;
            }

            if (txtSchContact.TextLength < 8)
            {
                MessageBox.Show("Contact Number must be in 8 digit numbers");
                txtSchContact.Focus();
                return;
            }

            //Validation #1 for Email textbox
            if (txtSchEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Email address");
                txtSchEmail.Focus();
                return;
            }

            //Validation #2 for Email textbox
            bool email = txtSchEmail.Text.Contains("@");
            bool email2 = txtSchEmail.Text.Contains(" ");

            if (email == false)
            {
                MessageBox.Show("Email must have @", "Invalid email address");
                txtSchEmail.Focus();
                return;
            }

            else if (email2 == true)
            {
                MessageBox.Show("Email cannot have blank in between the email address.", "Invalid email address");
                txtSchEmail.Focus();
                return;
            }

            //Validation for Address textbox
            if (txtSchAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Address");
                txtMemAddress.Focus();
                return;
            }


            //Edit the previous School Subscription Detail
            if (Program.getSchIdIndex(txtSchoolID.Text) < Program.maxSch) // ID exists in array(I found it)
            {

                Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].CONTACTNO = int.Parse(txtSchContact.Text);
                Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].EMAIL = txtSchEmail.Text;
                Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].ADDRESS = txtSchAddress.Text;
               
                updatedSchSubDetail();

                MessageBox.Show("Your particular has been edited");
            }
            else
            {

                MessageBox.Show("School ID " + Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].ID + " cannot be edited", "Error");
                txtSchoolID.Focus();
                return;
            }

        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {
            //Validation for SchoolID textbox
            if (txtMemberID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Member ID");
                txtMemberID.Focus();
                return;
            }

            //Validation for Name
            if (txtMemName.Text.Contains("0") == true || txtMemName.Text.Contains("1") == true || txtMemName.Text.Contains("2") == true || txtMemName.Text.Contains("3") == true
            || txtMemName.Text.Contains("4") == true || txtMemName.Text.Contains("5") == true || txtMemName.Text.Contains("6") == true || txtMemName.Text.Contains("7") == true
            || txtMemName.Text.Contains("8") == true || txtMemName.Text.Contains("9") == true)
            {
                MessageBox.Show("Name cannot be integer");
                txtMemName.Focus();
                return;
            }

            //Validation for Contact No textbox
            int contactNo;

            try
            {
                contactNo = int.Parse(txtMemContact.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Number must be in integer");
                txtMemContact.Focus();
                return;
            }

            if (txtMemContact.TextLength < 8)
            {
                MessageBox.Show("Contact Number must be in 8 digit numbers");
                txtMemContact.Focus();
                return;
            }

            //Validation #1 for Email textbox
            if (txtMemEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Email address");
                txtMemEmail.Focus();
                return;
            }

            //Validation #2 for Email textbox
            bool email = txtMemEmail.Text.Contains("@");
            bool email2 = txtMemEmail.Text.Contains(" ");

            if (email == false)
            {
                MessageBox.Show("Email must have @", "Invalid email address");
                txtMemEmail.Focus();
                return;
            }

            else if (email2 == true)
            {
                MessageBox.Show("Email cannot have blank in between the email address.", "Invalid email address");
                txtMemEmail.Focus();
                return;
            }

            //Validation for Address textbox
            if (txtMemAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Address");
                txtMemAddress.Focus();
                return;
            }



            
            //Edit the previous Member Subscription Detail
            if (Program.getIdIndex(txtMemberID.Text) < Program.maxMemberSubscriber) // ID exists in array(I found it)
            {

                Program.eArray[Program.getIdIndex(txtMemberID.Text)].CONTACTNO = int.Parse(txtMemContact.Text);
                Program.eArray[Program.getIdIndex(txtMemberID.Text)].Email = txtMemEmail.Text;
                Program.eArray[Program.getIdIndex(txtMemberID.Text)].Address = txtMemAddress.Text;

                updatedMemSubDetail();

                MessageBox.Show("Your particular has been edited");


            }
            else
            {

                MessageBox.Show("Member ID " +  Program.eArray[Program.getIdIndex(txtMemberID.Text)].ID + " cannot be edited", "Error");
                txtMemberID.Focus();
                return;
            }
        }

        private void btnSchRetrieve_Click(object sender, EventArgs e)
        {
            //Validation for SchoolID textbox
            if (txtSchoolID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your School ID");
                txtSchoolID.Focus();
                return;
            }

            

            
            //Retrieve the previous School Subscription Detail
            if (Program.getSchIdIndex(txtSchoolID.Text) < Program.maxSch) // ID exists in array(I found it)
            {
                updatedSchSubDetail();

                txtSchoolID.Enabled = false;
                txtSchName.Enabled = false;
                txtSchContact.Focus();
            }

            else
            {
                MessageBox.Show("The School ID is not exist", "Error");
                txtSchContact.Focus();
                return;
            }
        }

        private void updatedSchSubDetail()
        {
 
            txtSchoolID.Text = Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].ID;
            txtSchName.Text = Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].getName();
            txtSchContact.Text = Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].CONTACTNO.ToString();
            txtSchEmail.Text = Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].EMAIL;
            txtSchAddress.Text = Program.schArray[Program.getSchIdIndex(txtSchoolID.Text)].ADDRESS;
        }

        

        
        private void btnMemRetrieve_Click(object sender, EventArgs e)
        {
             //Validation for SchoolID textbox
            if (txtMemberID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your Member ID");
                txtMemberID.Focus();
                return;
            }

            

            
            //Retrieve the previous School Subscription Detail
            if (Program.getIdIndex(txtMemberID.Text) < Program.maxMemberSubscriber) // ID exists in array(I found it)
            {
                updatedMemSubDetail();

                txtMemberID.Enabled = false;
                txtMemName.Enabled = false;
                txtMemContact.Focus();
            }

            else
            {
                MessageBox.Show("The Member ID is not exist", "Error");
                txtMemContact.Focus();
                return;
            }
        }

        private void updatedMemSubDetail()
        {
 
            txtMemberID.Text = Program.eArray[Program.getIdIndex(txtMemberID.Text)].ID;
            txtMemName.Text = Program.eArray[Program.getIdIndex(txtMemberID.Text)].getName();
            txtMemContact.Text = Program.eArray[Program.getIdIndex(txtMemberID.Text)].CONTACTNO.ToString();
            txtMemEmail.Text = Program.eArray[Program.getIdIndex(txtMemberID.Text)].Email;
            txtMemAddress.Text = Program.eArray[Program.getIdIndex(txtMemberID.Text)].Address;
        }
        
        

        
  }
    
}
