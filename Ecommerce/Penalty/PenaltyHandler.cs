using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public static class PenaltyHandler
    {
        public static void ServiceDisconnectPenalty(float amount)
        {
            Console.WriteLine("Disconnection Chareges Applied" + amount);
        }
        public static void NotificationPenaltyCharges(float amount)
        {
            Console.WriteLine("Notification Charges Appleid " + amount);

        }


    }
}
