using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_pigege
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYes_MouseEnter(object sender, EventArgs e)
        {
            this.buttonYes.Text = "是的！";
            this.buttonNo.Text = "不是~";
        }

        private void buttonNo_MouseEnter(object sender, EventArgs e)
        {
            this.buttonYes.Text = "不是~";
            this.buttonNo.Text = "是的！";
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是必须的！","恭喜你答对了");
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4444444444！", "恭喜你答对了");
       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("皮哥你想多了!", "杜江皮同学！");
            e.Cancel = true;
            base.OnClosing(e);
        }
    }
}
