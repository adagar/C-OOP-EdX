using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_playground
{
    class Customer : ILoyaltyCardHolder
    {
        //BEGIN Interface implementation
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }

        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }
        public void ResetPoints()
        {
            totalPoints = 0;
        }
        // END Interface Implementation
    }
}
