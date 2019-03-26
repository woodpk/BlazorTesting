using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PhoenixCharts.Shared.Models
{
    public class CountDown
    {



        // ***************************************************
        // REMOVE ENCLOSED CODE WHEN FULL SOLUTION IS COMPLETE
        // ***************************************************
        private int Count { get; set; } = 50;
        public void StartCountdown()
        {
            var timer = new Timer(new TimerCallback(_ =>
            {
                if (Count > 0)
                {
                    Count--;
                }
            }), null, 1000, 1000);
        }
        // ***************************************************
        // REMOVE ENCLOSED CODE WHEN FULL SOLUTION IS COMPLETE
        // ***************************************************




    }
}
