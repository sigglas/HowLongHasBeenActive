using ScreenCapyure2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    internal class ScreenEvent
    {
        private readonly Form mainForm;
        private Action userActived;

        public ScreenEvent(Form1 form1, Action userActived)
        {
            this.mainForm = form1;
            this.userActived = userActived;
        }

        public ScreenEvent(Form1 form1, Action userActived, Action<Point, Point> calculateTravelDistance) : this(form1, userActived)
        {
            this.calculateTravelDistance = calculateTravelDistance;
        }

        public ScreenEvent(Form1 form1, Action userActived, Action<Point, Point> calculateTravelDistance, Action calculateKeyPressCount) : this(form1, userActived, calculateTravelDistance)
        {
            this.calculateKeyPressCount = calculateKeyPressCount;
        }

        public void BeginForm()
        {
            UserActivityHook choosesc;

            choosesc = new UserActivityHook();
            choosesc.OnMouseActivity += new MouseEventHandler(choose_OnMouseActivity);
            //choosesc.KeyDown += new KeyEventHandler(MyKeyDown);
            choosesc.KeyPress += Choosesc_KeyPress;
            //choosesc.KeyUp += new KeyEventHandler(MyKeyUp);
        }

        private void Choosesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 0)
            {
                userActived();
                calculateKeyPressCount();
            }
        }

        Point lastPoint = Point.Empty;
        private Action<Point, Point> calculateTravelDistance;
        private Action calculateKeyPressCount;

        void choose_OnMouseActivity(object sender, MouseEventArgs e)
        {
            if (lastPoint.X != e.Location.X && lastPoint.Y != e.Location.Y)
            {
                userActived();
                if (calculateTravelDistance != null)
                    calculateTravelDistance(e.Location, lastPoint);
                lastPoint = e.Location;
            }
        }

    }
}
