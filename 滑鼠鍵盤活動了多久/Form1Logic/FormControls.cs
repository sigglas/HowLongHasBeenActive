using System;
namespace 滑鼠鍵盤活動了多久
{
    public partial class Form1
    {

        public void Sent_ActiveResults(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                lab_activeTime.ResetText();
            }
            else
                lab_activeTime.Text = value;

        }

        public void Sent_StopResults(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                lab_stopTime.ResetText();
            }
            else
                lab_stopTime.Text = value;

        }

        private static decimal nowDistanceM = 0;
        public void Sent_DistanceResults(decimal value)
        {
            if (value > 0)
            {
                if ((decimal.MaxValue - nowDistanceM) < value)
                    lab_distance.Text = "無法計算了";
                else
                {
                    nowDistanceM += value;
                    var nowM = DecimalTruncate(nowDistanceM, 2);
                    if (nowM < 1000)
                        lab_distance.Text = $"{nowM.ToString()}m";
                    else
                    {
                        lab_distance.Text = $"{DecimalTruncate(nowM / 1000m, 3)}km";
                    }
                }
            }

        }
        public decimal DecimalTruncate(decimal value, int places)
        {
            var f = (decimal)Math.Pow(10, places);
            var tmp = decimal.Truncate(value * f) / f;
            return tmp;
        }

        private static long nowKeyPressCount = 0;
        public void Sent_KeyPressResults(long value)
        {
            if (value <= 0)
            {
                lab_keyCount.ResetText();
            }
            else
            {
                nowKeyPressCount = nowKeyPressCount + value;
                lab_keyCount.Text = nowKeyPressCount.ToString();
            }
        }
    }
}
