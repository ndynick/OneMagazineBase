using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{
    public partial class MenuForm : Happy_Magazines_Subscription.BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            SchoolSubscriptionForm goSchSubscriptionForm = new SchoolSubscriptionForm();
            goSchSubscriptionForm.ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            MemberSubscriptionForm goMemberSubscriptionForm = new MemberSubscriptionForm();
            goMemberSubscriptionForm.ShowDialog();
        }
    }
}
