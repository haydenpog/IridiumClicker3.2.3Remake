using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iridium_Remake
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hwnd, int msg, int wparam, int lparam);

        [DllImport("user32.dll")]

        static extern bool ReleaseCapture();
        const int WmNcLButtonDown = 0xA1;
        const int HtCaption = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WmNcLButtonDown, HtCaption, 0);
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
