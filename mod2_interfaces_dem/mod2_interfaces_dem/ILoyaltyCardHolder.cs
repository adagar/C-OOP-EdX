using System;
using System.Collections.Generic;
using System.Text;

namespace mod2_interfaces_dem
{
    interface ILoyaltyCardHolder        
    {
        int TotalPoitns { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}
