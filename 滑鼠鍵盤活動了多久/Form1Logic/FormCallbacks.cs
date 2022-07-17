using System;
using System.Drawing;
using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    public partial class Form1
    {
        public void TimerCallbackMethod(object State)
        {
            Delegate_Sender<string> SentActiveResults = Sent_ActiveResults;
            Delegate_Sender<string> SentStopResults = Sent_StopResults;
            if (State != null)
            {
                if (isWorking)
                {
                    howManyTimeActive += TimeSpan.FromSeconds(1);
                    this.Invoke(SentActiveResults, howManyTimeActive.ToString());
                    isWorking = false;
                }
                else
                {
                    howManyTimeStop += TimeSpan.FromSeconds(1);
                    this.Invoke(SentStopResults, howManyTimeStop.ToString());
                }
            }
        }

        public void UserActived()
        {
            isWorking = true;
        }

        public void CalculateTravelDistance(Point nowPoint, Point lastPoint)
        {
            //根號 ((x2-x1)^2 + (y2-y1)^2)

            //螢幕物理大小(理論值)
            var scr = SystemDevice.GetScreenMillimeters();
            if (scr.Height > 0 && scr.Width > 0)
            {
                var x = nowPoint.X - lastPoint.X;
                var y = nowPoint.Y - lastPoint.Y;

                //解析度比率(公尺換算)
                var pw = Screen.PrimaryScreen.Bounds.Width / ((decimal)scr.Width / 10 / 100);
                var ph = Screen.PrimaryScreen.Bounds.Height / ((decimal)scr.Height / 10 / 100);
                var mmX = x / pw;
                var mmY = y / ph;

                //計算距離(公尺)
                var p2 = Sqrt((mmX * mmX) + (mmY * mmY));
                if (p2 > 0)
                {
                    Delegate_Sender<decimal> SentDistanceResults = Sent_DistanceResults;
                    this.Invoke(SentDistanceResults, p2);
                }
            }
        }

        public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) return 0m;

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }
        public void CalculateKeyPressCount()
        {
            Delegate_Sender<long> SentKeyPressResults = Sent_KeyPressResults;
            this.Invoke(SentKeyPressResults, 1);
        }
    }
}
