using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace Mald_Muter
{
    public partial class splashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public splashScreen()
        {
            InitializeComponent();
            moveLabel2.Size = new Size(300, 27);
            moveLabel2.BackColor = Color.FromArgb(32, 34, 37);
            moveLabel2.Parent = this;
        }
        
        MoveLabel moveLabel2 = new MoveLabel();
        class MoveLabel : Label
        {
            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                this.Capture = false;
                Message msg = Message.Create(Parent.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void enableBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; 
            pictureBox2.Visible = true;
            enableBtn.Visible = false;
            disableBtn.Visible = true;
        }
        private void disableBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            enableBtn.Visible = true;
            disableBtn.Visible = false;
        }

        private void dashBtn_DragLeave(object sender, EventArgs e)
        {
             dashBtn.BackColor = Color.FromArgb(64, 68, 75);
        }

        private void settingsBtn_DragLeave(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.FromArgb(64,68,75);
        }
    }
}