using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserManageInfo where ID = '" + txt_LoginID.Text + "' and PW = '" + txt_LoginPW.Text + "'", dbcon);
            DataTable newTable = new DataTable();
            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("일반회원 로그인에 성공했습니다.", "성공");

                this.Visible = false;
                User showUser = new User();
                showUser.ShowDialog();
            }

            else if (txt_LoginID.Text == "Admin" && txt_LoginPW.Text == "0000")
            {
                MessageBox.Show("관리자 로그인에 성공했습니다.", "성공");

                this.Visible = false;
                Admin showAdmin = new Admin();
                showAdmin.ShowDialog();
            }
            else
                MessageBox.Show("아이디, 비밀번호를 확인하세요.", "실패");
        }

        private void btn_GoSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sign_Up showSign_Up = new Sign_Up();
            showSign_Up.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
