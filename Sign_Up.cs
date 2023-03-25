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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string ID = txt_SignID.Text;
            string PW = txt_SignPW.Text;
            string NAME = txt_SignName.Text;
            string SEX = radio_Male.Checked ? "Male" : "Female";
            string BIRTH = txt_SignBirth.Text;
            string ADDRESS = txt_SignAdd.Text;
            string TEL = txt_SignTel.Text;

            if (ID!="" && PW!="" && NAME!="" && BIRTH!="")
            {
                try
                {
                    SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
                    dbcon.Open();
                    string signup = $"insert into UserManageInfo(ID, PW, NAME, SEX, BIRTH, ADDRESS, TEL) values ('{ID}', '{PW}', '{NAME}', '{SEX}', '{BIRTH}', '{ADDRESS}', '{TEL}')";
                    SqlCommand cmd_Insert = new SqlCommand(signup, dbcon);
                    cmd_Insert.ExecuteNonQuery();
                    dbcon.Close();

                    MessageBox.Show("회원가입 완료!", "성공");

                    this.Visible = false;
                    Login showLogin = new Login();
                    showLogin.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("이미 존재하는 ID입니다.\n다른 ID를 입력해주세요.", "실패");
                }
            }
            else MessageBox.Show("필수 정보를 입력해주세요.", "실패");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login showLogin = new Login();
            showLogin.ShowDialog();
        }

        private void Sign_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
