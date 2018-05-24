using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_interfaces_dem
{
    class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }
        public int AddPoitns(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }
        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}
