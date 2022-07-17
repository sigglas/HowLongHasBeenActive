using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    public partial class Form1 : Form
    {
        private static System.Threading.Timer timer;
        TimeSpan howManyTimeActive = TimeSpan.Zero;
        TimeSpan howManyTimeStop = TimeSpan.Zero;
        bool isWorking = false;
        public delegate void Delegate_Sender<T>(T name);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Top + 5);

            timer = new System.Threading.Timer(new TimerCallback(TimerCallbackMethod), new object(), 0, 1000);

            new ScreenEvent(this, UserActived, CalculateTravelDistance, CalculateKeyPressCount).BeginForm();

            // 設置背景全透明
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = Color.AliceBlue;

            //文字白色
            label1.ForeColor =
                label4.ForeColor =
                lab_activeTime.ForeColor =
                lab_stopTime.ForeColor =
                lab_distance.ForeColor =
                label5.ForeColor =
                label3.ForeColor =
                lab_keyCount.ForeColor =                
                Color.White;

            //歸零
            lab_keyCount.Text = "0";
            lab_distance.Text = "0m";
            lab_stopTime.Text = "00:00:00";
            lab_activeTime.Text = "00:00:00";

            //後景透明
            FrmBackgound.Show(this, Color.FromArgb(196, 213, 255), 0.8);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
