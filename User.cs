using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cal.Clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_cal.Text.Length > 0)
            {
                string text = txt_cal.Text;
                txt_cal.Text = text.Substring(0, txt_cal.TextLength - 1);
            }
        }

        private void btn_divremain_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "%";
        }

        private void btn_divquo_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "/";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "*";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "-";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "+";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            string str = txt_cal.Text.ToString();
            int len = str.Length;

            if (txt_cal.Text[--len] != '.') txt_cal.Text += ".";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_cal.Text += "9";
        }

        private void btn_equl_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var a = dt.Compute(txt_cal.Text, "");
                txt_cal.Text = a.ToString();
            }
            catch
            {
                MessageBox.Show("잘못된 계산식 입니다.", "에러");
            }
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login showLogin = new Login();
            showLogin.ShowDialog();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
