using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Happy_Magazines_Subscription
{
    //Done by Ding Xun

    class MemberSubscriber : Subscriber
    {
       
        private string id;
        protected string email;
        protected string address;
        decimal price;
        decimal rewardPoints;

        public MemberSubscriber()
        {
        }

        public const decimal MemberDiscount = 0.02m;
        public static decimal CalculateTotal(decimal p, int y)
        {
            decimal total = (p - (p * MemberDiscount)) * y;
            return total;
        }

        public static decimal CalculateRewardPoints(decimal p, int y)
        {
            decimal total = (p - (p * MemberDiscount)) * y;
            decimal Reward_Points = total / 10;
            return Reward_Points;
        }

        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

   
        public decimal Price
        {
            set { price = value; }
            get { return price; }
        }

        public decimal RewardPoints
        {
            set { rewardPoints = value; }
            get { return rewardPoints; }
        }


        public MemberSubscriber(string i, string n, int c, string e, string a, string d, int y, string ms, string cs, decimal dr, int sc, decimal rp, decimal t)
            : base(n, c, d, y, ms, cs, dr, sc, t)
        {
            id = i;
            email = e;
            address = a;
            rewardPoints = rp;
        }
         
    }
}
