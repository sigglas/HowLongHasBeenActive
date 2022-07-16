using ScreenCapyure2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 活動了多久
{
    internal class FormEvent
    {
        private readonly Form mainForm;
        private Action userActived;

        public FormEvent(Form1 form1, Action userActived)
        {
            this.mainForm = form1;
            this.userActived = userActived;
        }

        public void BeginForm()
        {
            UserActivityHook choosesc;

            choosesc = new UserActivityHook();
            choosesc.OnMouseActivity += new MouseEventHandler(choose_OnMouseActivity);
            //choosesc.KeyDown += new KeyEventHandler(MyKeyDown);
            //choosesc.KeyPress += new KeyPressEventHandler(MyKeyPress);
            //choosesc.KeyUp += new KeyEventHandler(MyKeyUp);
        }

        Point lastPoint = Point.Empty;
        void choose_OnMouseActivity(object sender, MouseEventArgs e)
        {
            if (lastPoint.X != e.Location.X && lastPoint.Y != e.Location.Y)
            {
                userActived();
                lastPoint = e.Location;
            }
        }

    }
}
