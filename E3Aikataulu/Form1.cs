using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Aikataulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Highlight
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        #endregion

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EAPanel eaPanel = new EAPanel();
            eaPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
