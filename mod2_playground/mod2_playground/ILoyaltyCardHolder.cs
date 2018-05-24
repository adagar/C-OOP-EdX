using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_playground
{
    interface ILoyaltyCardHolder
    {
        //this is a read only property, hence, no set
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}
