using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Happy_Magazines_Subscription
{
    interface ISubscription
    {
        decimal getTotalDiscount();
    }

    //Done by Nick Low and Ding Xun

    abstract class Subscriber: ISubscription //Parent Class
    {
        public string name;
        private int contactNo;
        private int noOfyears;
        private decimal totalamount;
        private string magazineString;
        private string cardTypeString;
        protected decimal discountRate;
        protected int subscriptionCount;
        private string date;

        virtual public decimal getTotalDiscount()
        {
            return 0;
        }

        public Subscriber()
        {
        }

        public Subscriber(string n, int c, string d, int y, string ms, string cs, decimal dr, int sc, decimal t)
        {
            contactNo = c;
             name = n;
             noOfyears = y;
             date = d;
             magazineString = ms;
             cardTypeString = cs;
             discountRate = dr;
             subscriptionCount = sc;
             totalamount = t;
            
        }

        //name 
        public string getName()
         {
             return name;
         }
         public void setName(string n)
         {
             name = n;
         }

        //contactNo 
         public int CONTACTNO
         {
             get { return contactNo; }
             set { contactNo = value; }
         }


        //totalamount
        public decimal getTotalAmount()
        {
            return totalamount;
        }
        public void setTotalAmount(decimal t)
        {
            totalamount = t;
        }

        //noOfyears
        public int getNoOfYear()
        {
            return noOfyears;
        }

        public void setNoOfYear(int y)
        {
            noOfyears = y;
        }

        //magazineString
        public string getmagazineString()
        {
            return magazineString;
        }
        public void setmagazineString(string ms)
        {
            magazineString = ms;
        }

        //cardTypeString
        public string getCardTypeString()
        {
            return cardTypeString;
        }
        public void setCardTypeString(string cs)
        {
            cardTypeString = cs;
        }

        //subscriptionCount
        public int getSubscriptionCount()
        {
            return subscriptionCount;
        }
        public void setSubscriptionCount(int sc)
        {
            subscriptionCount = sc;
        }

        //date
        public string DATE
        {
             get {return date; }
            set { date = value; }
           
        }
    }
}
