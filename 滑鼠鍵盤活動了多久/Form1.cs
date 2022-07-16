using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    public partial class Form1 : Form
    {
        TimeSpan howManyTimeActive = TimeSpan.Zero;
        TimeSpan howManyTimeStop = TimeSpan.Zero;
        public Form1()
        {
            InitializeComponent();

        }

        void CallbackMethod(object State)
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

        bool isWorking = false;
        public void UserActived()
        {
            isWorking = true;
        }


        public delegate void Delegate_Sender<T>(T name);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Top + 5);

            System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(CallbackMethod), new object(), 0, 1000);
            new FormEvent(this, UserActived).BeginForm();

            // 設置背景全透明
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.AliceBlue;

            //文字白色
            label1.ForeColor = label4.ForeColor = lab_activeTime.ForeColor = lab_stopTime.ForeColor =
                Color.White;

            //後景透明
            FrmBackgound.Show(this, Color.FromArgb(196, 213, 255), 0.8);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
