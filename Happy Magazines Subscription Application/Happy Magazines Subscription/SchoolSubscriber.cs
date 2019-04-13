using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Happy_Magazines_Subscription
{
    //Done by Nick Low

    class SchoolSubscriber: Subscriber
    {
        
        private string id;
        private string email;
        private string address;
        private decimal subAfterDiscount;
        private decimal subAfterRebate;
        public const decimal SCHOOL_DISCOUNTDecimal = 0.0125m;
        public const decimal rebateDecimal = 0.005m;


        public static decimal calculateFinalSubscriptionAmount(decimal p,int y )
        {
            decimal totalprice = p * y;
            totalprice = totalprice - ( (p * y) * SCHOOL_DISCOUNTDecimal );
            return totalprice; 
        }

       //id
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        //email
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        //address
        public string ADDRESS   
        {
            get { return address; }
            set { address = value; }
        }


        //subAfterDiscount
        public decimal getSubAfterDiscount()
        {
            return subAfterDiscount;
        }

        public void setSubAfterDiscount(decimal subD)
        {
            subAfterDiscount = subD;
        }

        //subAfterRebate
        public decimal getSubAfterRebate()
        {
            return subAfterRebate;
        }

        public void setSubAfterRebate(decimal subR)
        {
            subAfterRebate = subR;
        }

        public SchoolSubscriber(string i, string n, int c, string e, string a, string d, int y, string ms, string cs, decimal dr, int sc, decimal t, decimal subD, decimal subR)
            : base(n, c, d, y, ms, cs, dr, sc, t)
        {
            id = i;
            email = e;
            address = a;
            subAfterDiscount = subD;
            subAfterRebate = subR;
            
        }
    }
}
 