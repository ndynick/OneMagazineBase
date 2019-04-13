using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{

    public partial class MemberSubscriptionForm : Happy_Magazines_Subscription.BaseForm
    {
        public MemberSubscriptionForm()
        {
            InitializeComponent();
        }

        string magazine; 
        decimal discountRate;
        string cardType; 
        int subscriptionCount;
        decimal subscriptionTotal;
        decimal rewardPoints=0;
        

        MemberSubscriber obj = new MemberSubscriber();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {   
          
                int index;
                index = Program.getNextIndex();
                if (index >= Program.maxMemberSubscriber) 
                {
                    MessageBox.Show("Reached maximum subscriptions");
                    return;
                }

                //Validation for MemberID textbox
                if (txtMemberID.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in your ID");
                    txtMemberID.Focus();
                    return;
                }

                if (Program.getIdIndex(txtMemberID.Text) < Program.maxMemberSubscriber)
                {
                    MessageBox.Show("ID has already been taken. Please enter a different ID");
                    txtMemberID.Focus();
                    return;
                }

               
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in your Name");
                    txtName.Focus();
                    return;
                }

                if (txtName.Text.Contains("0") == true || txtName.Text.Contains("1") == true || txtName.Text.Contains("2") == true || txtName.Text.Contains("3") == true
                || txtName.Text.Contains("4") == true || txtName.Text.Contains("5") == true || txtName.Text.Contains("6") == true || txtName.Text.Contains("7") == true
                || txtName.Text.Contains("8") == true || txtName.Text.Contains("9") == true)
                {
                    MessageBox.Show("Name cannot be integer");
                    txtName.Focus();
                    return;
                }
               

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

                if (txtContact.TextLength < 8)
                {
                    MessageBox.Show("Contact Number must be in 8 digit numbers");
                    txtContact.Focus();
                    return;
                }

                if (txtEMail.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in your Email address");
                    txtEMail.Focus();
                    return;
                }

                //Validation #1 for Email textbox
                if (txtEMail.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in your Email address");
                    txtEMail.Focus();
                    return;
                }

                //Validation #2 for Email textbox
                bool email = txtEMail.Text.Contains("@");
                bool email2 = txtEMail.Text.Contains(" ");

                if (email == false)
                {
                    MessageBox.Show("Email must have @", "Invalid email address");
                    txtEMail.Focus();
                    return;
                }

                else if (email2 == true)
                {
                    MessageBox.Show("Email cannot have blank in between the email address.", "Invalid email address");
                    txtEMail.Focus();
                    return;
                }

                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in your Address");
                    txtAddress.Focus();
                    return;
                }

                if (txtSubscriptionYears.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter subscription years");
                    txtSubscriptionYears.Focus();
                    return;
                }

            

                if ((rdoParenting.Checked || rdoFilms.Checked || rdoFootball.Checked || rdoCars.Checked)
                   && (rdoVisa.Checked || rdoAmericanExpress.Checked || rdoMaster.Checked || rdoKrisflyer.Checked))
                {
                    if (rdoParenting.Checked)
                    {
                        magazine = rdoParenting.Text;
                        subscriptionTotal = MemberSubscriber.CalculateTotal(80.00m, int.Parse(txtSubscriptionYears.Text));
                        rewardPoints = subscriptionTotal / 10;
                        cardType = rdoVisa.Text;
                    }
                    if (rdoFilms.Checked)
                    {
                        magazine = rdoFilms.Text;
                        subscriptionTotal = MemberSubscriber.CalculateTotal(95.00m, int.Parse(txtSubscriptionYears.Text));
                        rewardPoints = subscriptionTotal / 10;
                        cardType = rdoMaster.Text;
                    }
                    if (rdoFootball.Checked)
                    {
                        magazine = rdoFootball.Text;
                        subscriptionTotal = MemberSubscriber.CalculateTotal(90.00m, int.Parse(txtSubscriptionYears.Text));
                        rewardPoints = subscriptionTotal / 10;
                        cardType = rdoAmericanExpress.Text;
                    }
                    if (rdoCars.Checked)
                    {
                        magazine = rdoCars.Text;
                        subscriptionTotal = MemberSubscriber.CalculateTotal(100.00m, int.Parse(txtSubscriptionYears.Text));
                        rewardPoints = subscriptionTotal / 10;
                        cardType = rdoKrisflyer.Text;
                    }


                    //MessageBox to show the user all the Member Subscription Detail
                    MessageBox.Show("[Member Subscription Detail]" + Environment.NewLine
                    + "-Member ID: " + txtMemberID.Text + Environment.NewLine
                    + "-Name: " + txtName.Text + Environment.NewLine
                    + "-Contact No: " + txtContact.Text + Environment.NewLine
                    + "-E-Mail: " + txtEMail.Text + Environment.NewLine
                    + "-Address: " + txtAddress.Text + Environment.NewLine
                    + "-Date: " + dateTimePickerMem.Text + Environment.NewLine
                    + "-Subscription Years: " + txtSubscriptionYears.Text + Environment.NewLine
                    + "-Magazine: " + magazine + Environment.NewLine
                    + "-Payment Method: " + cardType + Environment.NewLine
                    + "-Reward Points: " + rewardPoints.ToString("N2") + Environment.NewLine
                    + "-Total price after discount: " + subscriptionTotal.ToString("C") + Environment.NewLine);
                    
                }

                else
                {
                    MessageBox.Show("Please fill in subscription details");
                    return;
                }

                Program.eArray[index] = new MemberSubscriber(txtMemberID.Text, txtName.Text, contactNo, txtEMail.Text, txtAddress.Text, dateTimePickerMem.Text, int.Parse(txtSubscriptionYears.Text) ,
                   magazine, cardType, discountRate, subscriptionCount, rewardPoints, subscriptionTotal);

                MessageBox.Show("New subscription recorded");

                txtMemberID.Text = "";
                txtName.Text = "";
                txtContact.Text = "";
                txtEMail.Text = "";
                txtAddress.Text = "";
                txtSubscriptionYears.Text = "";
                rdoParenting.Checked = false;
                rdoFilms.Checked = false;
                rdoFootball.Checked = false;
                rdoCars.Checked = false;
                rdoMaster.Checked = false;
                rdoVisa.Checked = false;
                rdoAmericanExpress.Checked = false;
                rdoKrisflyer.Checked = false;

                txtMemberID.Focus(); 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.maxMemberSubscriber; i++)
            {
                if (Program.eArray[i] != null)
                {
                    listBoxMemberDisplay.Items.Add("<[Member ID: " + Program.eArray[i].ID + " ] "
                         + "[Name: " + Program.eArray[i].getName() + " ] "
                         + "[Contact Number: " + Program.eArray[i].CONTACTNO + " ] "
                         + "[Email: " + Program.eArray[i].Email + " ] "
                         + "[Address: " + Program.eArray[i].Address + " ] "
                         + "[Date: " + Program.eArray[i].DATE + " ] "
                         + "[Subscription Years: " + Program.eArray[i].getNoOfYear().ToString() + " ] "
                         + "[Magazine: " + Program.eArray[i].getmagazineString() + " ] "
                         + "[Payment Method: " + Program.eArray[i].getCardTypeString() + " ] "
                         + "[Reward Points: " + Program.eArray[i].RewardPoints.ToString("N2") + " ] "
                         + "[Total price after discount: " + Program.eArray[i].getTotalAmount().ToString("C") + " ]>" ); 
                    
                }
            }

            listBoxMemberDisplay.HorizontalScrollbar = true;
            tabControl1.SelectedTab = Display_Member;
        }

        private void btnCalculateRewardsPts_Click(object sender, EventArgs e)
        {
            if (txtRewardPointsMemberID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in your member ID");
                txtRewardPointsMemberID.Focus();
                return;
            }
            if (Program.getIdIndex(txtRewardPointsMemberID.Text) < Program.maxMemberSubscriber)
            {
                int s = Program.getIdIndex(txtRewardPointsMemberID.Text);

                txtSubscriptionAmount.Text = Program.eArray[s].getTotalAmount().ToString("C");
                txtRewardPoints.Text = Program.eArray[s].RewardPoints.ToString("N2");
                
            }
            else
            {
                MessageBox.Show("Sorry, your Member ID is invalid");
                txtRewardPointsMemberID.Focus();
                return;
            }
        }

        private void btnRedeemRewards_Click(object sender, EventArgs e)
        {
            decimal RewardPts = decimal.Parse(txtRewardPoints.Text);

            for (int i = 0; i < Program.maxMemberSubscriber; i++)
            {
                if (Program.eArray[i] != null)
                {
                    txtRewardPoints.Text = Program.eArray[i].RewardPoints.ToString("N2");

                    if (rdoFreePopularVoucher.Checked)
                    {
                        if (rewardPoints >= 5)
                        {
                            RewardPts = RewardPts - 5m;
                            MessageBox.Show("Congratulations, you have successfully redeem a free $5 popular voucher!");
                            txtRewardPointsLeft.Text = RewardPts.ToString("N2");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, you do not have enough reward points to redeem this item.");
                            return;
                        }
                    }

                    if (rdoFreeWatch.Checked)
                    {
                        if (rewardPoints >= 10)
                        {
                            RewardPts = RewardPts - 10m;
                            MessageBox.Show("Congratulations, you have successfully redeem a free 'Happy' Brand Watch worth $30!");
                            txtRewardPointsLeft.Text = RewardPts.ToString("N2");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, you do not have enough reward points to redeem this item.");
                            return;
                        }
                    }

                    if (rdoFreeRobinsonsVoucher.Checked)
                    {
                        if (rewardPoints >= 25)
                        {
                            RewardPts = RewardPts - 25m;
                            MessageBox.Show("Congratulations, you have successfully redeem a free $50 Robinsons voucher!");
                            txtRewardPointsLeft.Text = RewardPts.ToString("N2");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, you do not have enough reward points to redeem this item.");
                            return;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please select an option.");
                    return;
                }
            }            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayALL_Click(object sender, EventArgs e)
        {
            DisplayAll goDisplayALL = new DisplayAll();
            goDisplayALL.ShowDialog();
            
        }

        private void btnGoToSchSub_Click(object sender, EventArgs e)
        {
            SchoolSubscriptionForm goSchSubForm = new SchoolSubscriptionForm();
            goSchSubForm.ShowDialog();
        }

        
        
    }
}

                        
                       