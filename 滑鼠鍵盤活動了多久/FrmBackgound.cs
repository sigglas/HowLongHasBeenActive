using System.Drawing;
using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    internal class FrmBackgound
    {
        public static void Show(Form frmBackOwner, Color frmBackColor, double frmBackOpacity)
        {
            // 背景窗體設置
            var frmBack = new Form();
            frmBack.FormBorderStyle = FormBorderStyle.None;
            frmBack.StartPosition = FormStartPosition.Manual;
            frmBack.ShowIcon = false;
            frmBack.ShowInTaskbar = false;
            frmBack.Opacity = frmBackOpacity;
            frmBack.BackColor = frmBackColor;
            frmBack.Owner = frmBackOwner;
            frmBack.Size = frmBackOwner.Size;
            frmBack.Location = frmBackOwner.Location;
            frmBack.Show();
        }
    }
}
