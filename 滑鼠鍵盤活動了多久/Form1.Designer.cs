using System.Windows.Forms;

namespace 滑鼠鍵盤活動了多久
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_activeTime = new System.Windows.Forms.Label();
            this.lab_stopTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_distance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_keyCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "活動時間：";
            // 
            // lab_activeTime
            // 
            this.lab_activeTime.AutoSize = true;
            this.lab_activeTime.BackColor = System.Drawing.Color.Transparent;
            this.lab_activeTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lab_activeTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_activeTime.Location = new System.Drawing.Point(72, 7);
            this.lab_activeTime.Name = "lab_activeTime";
            this.lab_activeTime.Size = new System.Drawing.Size(63, 15);
            this.lab_activeTime.TabIndex = 3;
            this.lab_activeTime.Text = "HH:mm:ss";
            // 
            // lab_stopTime
            // 
            this.lab_stopTime.AutoSize = true;
            this.lab_stopTime.BackColor = System.Drawing.Color.Transparent;
            this.lab_stopTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lab_stopTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_stopTime.Location = new System.Drawing.Point(72, 22);
            this.lab_stopTime.Name = "lab_stopTime";
            this.lab_stopTime.Size = new System.Drawing.Size(63, 15);
            this.lab_stopTime.TabIndex = 5;
            this.lab_stopTime.Text = "HH:mm:ss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "停止時間：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lab_distance
            // 
            this.lab_distance.AutoSize = true;
            this.lab_distance.BackColor = System.Drawing.Color.Transparent;
            this.lab_distance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lab_distance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_distance.Location = new System.Drawing.Point(72, 37);
            this.lab_distance.Name = "lab_distance";
            this.lab_distance.Size = new System.Drawing.Size(40, 15);
            this.lab_distance.TabIndex = 7;
            this.lab_distance.Text = "km/m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "動了多遠：";
            // 
            // lab_keyCount
            // 
            this.lab_keyCount.AutoSize = true;
            this.lab_keyCount.BackColor = System.Drawing.Color.Transparent;
            this.lab_keyCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lab_keyCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_keyCount.Location = new System.Drawing.Point(72, 52);
            this.lab_keyCount.Name = "lab_keyCount";
            this.lab_keyCount.Size = new System.Drawing.Size(39, 15);
            this.lab_keyCount.TabIndex = 9;
            this.lab_keyCount.Text = "count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "敲了幾次：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(162, 73);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lab_keyCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_distance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_activeTime);
            this.Controls.Add(this.lab_stopTime);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label lab_activeTime;
        private Label lab_stopTime;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label lab_distance;
        private Label label5;
        private Label lab_keyCount;
        private Label label3;
    }
}

